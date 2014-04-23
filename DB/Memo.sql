CREATE TABLE Memo(
  ID TEXT PRIMARY KEY,
  Title varchare(30) Not Null, 
  Content TEXT Null, 
  Creater varchare(30)  Not Null,
  Updater varchare(30) Null,
  CreatedTime TEXT  Not Null, 
  UpdatedTime TEXT Null
);