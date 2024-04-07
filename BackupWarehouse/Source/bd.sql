CREATE TABLE entity
(
  entity_id TEXT PRIMARY KEY CHECK(entity_id != ''),
  code INTEGER NOT NULL,
  name TEXT NOT NULL CHECK(name != ''),
  meaning TEXT UNIQUE NOT NULL CHECK(meaning != ''),
  created_by TEXT NOT NULL CHECK(created_by != ''),
  created_at DATETIME NOT NULL DEFAULT current_timestamp,
  modified_by TEXT,
  modified_at DATETIME,
  delete_status_code BLOB DEFAULT 0
);

CREATE TABLE product
(
  product_id TEXT PRIMARY KEY CHECK(product_id != ''),
  name TEXT NOT NULL,
  e_status INTEGER NOT NULL,
  acceptance DATETIME NOT NULL DEFAULT current_timestamp,
  departure DATETIME,
  created_by TEXT NOT NULL CHECK(created_by != ''),
  created_at DATETIME NOT NULL DEFAULT current_timestamp,
  modified_by TEXT,
  modified_at DATETIME,
  delete_status_code BLOB DEFAULT 0
);

CREATE TABLE account
(
    account_id TEXT PRIMARY KEY CHECK (account_id != ''),
    name TEXT,
    login TEXT NOT NULL CHECK (login != ''),
    password TEXT NOT NULL CHECK(password != ''),
    e_access INTEGER NOT NULL DEFAULT 0,
    created_by TEXT NOT NULL CHECK(created_by != ''),
    created_at DATETIME NOT NULL DEFAULT current_timestamp,
    modified_by TEXT,
    modified_at DATETIME,
    delete_status_code BLOB DEFAULT 0
);

CREATE TABLE product_tag
(
    product_id TEXT NOT NULL CHECK(product_id != ''),
    e_tag TEXT NOT NULL CHECK(e_tag != ''),
    created_by TEXT NOT NULL CHECK(created_by != ''),
    created_at DATETIME NOT NULL DEFAULT current_timestamp,
    modified_by TEXT,
    modified_at DATETIME,
    delete_status_code BLOB DEFAULT 0,
    FOREIGN KEY (product_id) REFERENCES product (product_id),
    FOREIGN KEY (e_tag) REFERENCES entity (entity_id)
);
  
-- Существа по-умолчанию
INSERT INTO entity (entity_id, code, name, meaning, created_by)
VALUES 
  ('2ce78e96-3cc1-43bf-9f2f-88dfc3b774f3',0,'access','user','00000000-0000-0000-0000-000000000000'),
  ('aa9fbd20-7023-448f-bb46-4d1fdd049b85',1,'access','admin','00000000-0000-0000-0000-000000000000'),
  ('bf61b0eb-aea9-44db-8508-bea5232be5c6',	0,	'status',	'В наличии',	    '00000000-0000-0000-0000-000000000000',	'2024-04-05 07:28:42'),
  ('3babaf9a-60e2-4a07-a64d-7280354bb90d',	1,	'status',	'В пути',	        '00000000-0000-0000-0000-000000000000',	'2024-04-05 12:24:25'),
  ('a81a3062-d01e-483a-9420-4cbecd1f7f3a',	2,	'status',	'В отгрузки',	    '00000000-0000-0000-0000-000000000000',	'2024-04-05 16:05:02'),
  ('5ebeade7-2cf4-4595-8efe-44387278f057',	3,	'status',	'Нет в наличии',	'00000000-0000-0000-0000-000000000000',	'2024-04-05 16:05:18')

  
-- Аккаунт по-умолчанию
INSERT INTO account (account_id, name, login, password, e_access, created_by)
VALUES ('d3914497-8399-45a7-8794-6bdfe70f5caa',	'Администратор',	'Admin',	'Administrator',	1,	'00000000-0000-0000-0000-000000000000')
