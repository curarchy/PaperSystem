CREATE TABLE Artical (
    ID INTEGER PRIMARY KEY,
    Title TEXT,
    Content TEXT,
    Writter TEXT,
    Grade NUMERIC,
    Memo TEXT
);

INSERT INTO Artical (ID, Title, Content, Writter, Grade, Memo) values (0, "无", "无", "无", 9, "默认文章。勿删。");

CREATE TABLE Grade (
    ID INTEGER PRIMARY KEY,
    Key NUMERIC,
    Value TEXT
);

INSERT INTO Grade (Key, Value) values (1, "六上");
INSERT INTO Grade (Key, Value) values (2, "六下");
INSERT INTO Grade (Key, Value) values (3, "七上");
INSERT INTO Grade (Key, Value) values (4, "七下");
INSERT INTO Grade (Key, Value) values (5, "八上");
INSERT INTO Grade (Key, Value) values (6, "八下");
INSERT INTO Grade (Key, Value) values (7, "九上");
INSERT INTO Grade (Key, Value) values (8, "九下");
INSERT INTO Grade (Key, Value) values (9, "其它");

CREATE TABLE Level (
    ID INTEGER PRIMARY KEY,
    Key NUMERIC,
    Value TEXT
);

INSERT INTO Level (Key, Value) values (1, "超简单");
INSERT INTO Level (Key, Value) values (2, "简单");
INSERT INTO Level (Key, Value) values (3, "正常");
INSERT INTO Level (Key, Value) values (4, "难");
INSERT INTO Level (Key, Value) values (5, "超难");

CREATE TABLE Type (
    ID INTEGER PRIMARY KEY,
    Key NUMERIC,
    Value TEXT
);

INSERT INTO Type (Key, Value) values (1, "加点词解释");
INSERT INTO Type (key, Value) values (2, "默写");
INSERT INTO Type (Key, Value) values (3, "翻译");

DROP TABLE Question;

CREATE TABLE Question (
    ID INTEGER PRIMARY KEY,
    Level NUMERIC,
    Type NUMERIC,
    Question TEXT,
    Answer TEXT,
    Memo TEXT,
    Artical NUMERIC,
    Keyword TEXT,
    Grade NUMERIC,
    Paragraph NUMERIC
);

select ID, Level, MainContent, Type, Memo from Question t where 1=1


delete from Question;
delete from Artical where id != 0;
