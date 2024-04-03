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
)