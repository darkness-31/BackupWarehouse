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
                AutorizationErrorfullyEvent?.Invoke("�������� ����� ��� ������");
                return;
            }
            
            var guidAccount = rows[0]["account_id"].ConvertFromDbVal<Guid?>();
            if (guidAccount.HasValue)
            {
                CurrentAccoutn = Account.Get(guidAccount);
                AutorizationSuccessfullyEvent?.Invoke("�������� ����");
            }
            else
            {
                AutorizationErrorfullyEvent?.Invoke("�������� ����� ��� ������");
            }
        }

        internal static void Registration(string name, string login, string password, string passwordAgain)
        {
            if (string.IsNullOrEmpty(login))
            {
                RegistrationErrorfullyEvent?.Invoke("������ ����");
                return;
            }

            if (Account.IsExistLogin(login) && login.Length > 1 
                && login.Any(Char.IsDigit)) 
            {
                RegistrationErrorfullyEvent?.Invoke("����� ����� ��� ����������");
                return;
            }

            if (password.Length < 8)
            {
                RegistrationErrorfullyEvent?.Invoke("������ ������ 8 ��������");
                return;
            }
            if (!password.Any(Char.IsDigit))
            {
                RegistrationErrorfullyEvent?.Invoke("������ � ������ �� ������ �����");
                return;
            }

            if ( password != passwordAgain )
            {
                RegistrationErrorfullyEvent?.Invoke("������ �� ���������");
                return;
            }

            Account.Create(name, login, password, Entity.Get(Entity.eGroup.access), Guid.Empty);
            RegistrationSuccessfullyEvent?.Invoke("����������� ������ �������, ���������� �����");
        }
    }
}