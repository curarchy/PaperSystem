CREATE TABLE Question (
	ID INTEGER PRIMARY KEY,
	Level NUMERIC,
    Type NUMERIC,
	Question TEXT,
	Answer TEXT,
	Memo TEXT,
    Writter TEXT,
    Artical TEXT,
    Collection TEXT,
    Keyword TEXT,
    Grade TEXT);

select ID, Level, MainContent, Type, Memo from Question t where 1=1

DROP TABLE Question