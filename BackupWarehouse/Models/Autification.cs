using BackupWarehouse.Models.Utils;
using System;
using System.Linq;

namespace BackupWarehouse.Models
{
    public static class Autification
    {
        internal delegate void AutificationHandler(string message);
        internal static event AutificationHandler AutorizationSuccessfullyEvent;
        internal static event AutificationHandler RegistrationSuccessfullyEvent;
        internal static event AutificationHandler AutorizationErrorfullyEvent;
        internal static event AutificationHandler RegistrationErrorfullyEvent;

        internal static Account CurrentAccoutn { get; set; }

        internal static void Autorization(string login, string password)
        {
            var sql = $@"SELECT account_id
                         FROM account 
                         WHERE login = '{login}' AND
                         	   password = '{password}'";
            var rows = sql.SQLQueryAsDataTable().Rows;
            if (rows.Count == 0)
            {
                AutorizationErrorfullyEvent?.Invoke("Неверный логин или пароль");
                return;
            }
            
            var guidAccount = rows[0]["account_id"].ConvertFromDbVal<Guid?>();
            if (guidAccount.HasValue)
            {
                CurrentAccoutn = Account.Get(guidAccount);
                AutorizationSuccessfullyEvent?.Invoke("Успешный вход");
            }
            else
            {
                AutorizationErrorfullyEvent?.Invoke("Неверный логин или пароль");
            }
        }

        internal static void Registration(string name, string login, string password, string passwordAgain)
        {
            if (string.IsNullOrEmpty(login))
            {
                RegistrationErrorfullyEvent?.Invoke("Пустое поле");
                return;
            }

            if (Account.IsExistLogin(login) && login.Length > 1 
                && login.Any(Char.IsDigit)) 
            {
                RegistrationErrorfullyEvent?.Invoke("Такой логин уже существует");
                return;
            }

            if (password.Length < 8)
            {
                RegistrationErrorfullyEvent?.Invoke("Пароль меньше 8 символов");
                return;
            }
            if (!password.Any(Char.IsDigit))
            {
                RegistrationErrorfullyEvent?.Invoke("Пароль в пароль не входят цифры");
                return;
            }

            if ( password != passwordAgain )
            {
                RegistrationErrorfullyEvent?.Invoke("Пароли не совпадают");
                return;
            }

            Account.Create(name, login, password, Entity.Get(Entity.eGroup.access), Guid.Empty);
            RegistrationSuccessfullyEvent?.Invoke("Регистрация прошла успешно, попробуйте войти");
        }
    }
}