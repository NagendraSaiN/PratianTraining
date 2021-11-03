--Lab4
 
select * from cardiodiagnosis
select date,cardioarrestdetected from cardiodiagnosis
select date as Predication_Date, sum(cardioarrestdetected) as Predictions from cardiodiagnosis group by date; 

--Lab 5

select distinct city from addressinfo
select memberinfo_member_id from addressinfo where city = 'Flora'

--Lab 6

select memberinfo_member_id from addressinfo where city = 'Burgos'
/*
select count(blood_id) as count from bloodtest where cardiodiagnosis_cardio_id 
in (select cardio_id from cardiodiagnosis where memberinfo_member_id 
in (select member_id from memberinfo where firstname='aisha'))*/

select count(blood_id) as Countoftests from bloodtest 
inner join cardiodiagnosis c on cardiodiagnosis_cardio_id = c.cardio_id 
inner join memberinfo m on c.memberinfo_member_id = m.member_id where m.firstname='aisha' 

--Lab 7 

select * from xray where cardiodiagnosis_cardio_id 
in (select cardio_id from cardiodiagnosis where memberinfo_member_id
in (select member_id from memberinfo where firstname = 'Ajay' and date='2019-01-26'))

SELECT x.* FROM xray x JOIN cardiodiagnosis c ON x.cardiodiagnosis_cardio_id=c.cardio_id 
JOIN memberinfo m ON c.memberinfo_member_id=m.member_id 
WHERE m.firstname='ajay' AND c.date='2019-01-26';

--Lab 8
go
alter proc getMemberbyID @mem_id nvarchar(45)
as
select firstname,lastname,age from memberinfo where member_id = @mem_id
select * from memberinfo

EXEC getMemberbyID @mem_id = 'M111';

--Lab 9

go
alter PROCEDURE addMemberInfo(@mem_id varchar(45), 
@u_name varchar(45), @f_name varchar(45),@l_name varchar(45),@m_age int, @m_gender varchar(45),
@m_email varchar(45), @phone bigint )
as
BEGIN
    insert into memberinfo values(@mem_id,@u_name, @f_name, @l_name, 
    @m_age,@m_gender, @m_email, @phone);
END

exec addMemberInfo 'M3009','nagendra','N','s',21,'1','xyz@',8074;
Select * from memberinfo

--lab 10

go
create proc getXrayReport(@name varchar(45),@date datetime2)
as
begin
SELECT x.* FROM xray x JOIN cardiodiagnosis c ON x.cardiodiagnosis_cardio_id=c.cardio_id 
JOIN memberinfo m ON c.memberinfo_member_id=m.member_id 
WHERE m.firstname=@name AND c.date=@date;
end
 
 Select * from memberinfo
exec getXrayReport 'aisha','2019-01-26'

--Lab 11
Create function fn_Count()
returns int 
begin
	return(SELECT COUNT(*) FROM cardiodiagnosis WHERE cardioarrestdetected = '1')
end

SELECT dbo.fn_Count()


-- LAB 12 --
DECLARE @memb_id varchar(45), @username varchar(45), @firstname varchar(45), @age int;

DECLARE memb_cusror  CURSOR FOR
SELECT member_id, username, firstname,age FROM memberinfo WHERE age > 35;

OPEN memb_cusror 

FETCH NEXT FROM memb_cusror INTO @memb_id , @username , @firstname , @age;

Print '	' + 'Member id	username	firstname	age'

WHILE @@FETCH_STATUS = 0
BEGIN
	print '	' + CAST(@memb_id as varchar(45)) + '	' + CAST(@username as varchar(45))+ '		' + CAST(@firstname as varchar(45))+ '	' + CAST(@age as varchar(45))
	
	FETCH NEXT FROM memb_cusror INTO @memb_id , @username , @firstname , @age;
END
CLOSE memb_cusror;
DEALLOCATE memb_cusror;



-- LAB 13 --
DECLARE  @first_name varchar(45), @last_name varchar(45)

DECLARE memberinfo_cusror  CURSOR FOR
SELECT firstname, lastname FROM memberinfo;

OPEN memberinfo_cusror 

FETCH NEXT FROM memberinfo_cusror INTO @first_name , @last_name;

WHILE @@FETCH_STATUS = 0
BEGIN
	print 'The member name is : ' + CAST(@first_name as varchar(45))+ ' ' + CAST(@last_name as varchar(45))
	
	FETCH NEXT FROM  memberinfo_cusror INTO @first_name , @last_name;

END
CLOSE memberinfo_cusror;
DEALLOCATE memberinfo_cusror;


-- LAB 14 --
CREATE PROC sp_memberinfoByCity
@City varchar(45)
AS
BEGIN	

	DECLARE  @name varchar(45);

	DECLARE memberinfoByCity_cusror  CURSOR FOR

		SELECT m.firstname FROM memberinfo as m JOIN addressinfo as a ON m.member_id = a.memberinfo_member_id WHERE a.city = @City;

	OPEN memberinfoByCity_cusror 

	FETCH NEXT FROM memberinfoByCity_cusror INTO @name;

	WHILE @@FETCH_STATUS = 0
	BEGIN
		print ' ' + CAST(@name as varchar(45));
	
		FETCH NEXT FROM  memberinfoByCity_cusror INTO @name;

	END
	CLOSE memberinfoByCity_cusror;
	DEALLOCATE memberinfoByCity_cusror;

END

EXEC sp_memberinfoByCity 'Flora';


-- LAB 15 --
CREATE PROC sp_displayMemberInfo
@AgeParam int
AS
BEGIN

	DECLARE @memb_id varchar(45), @lastname varchar(45), @firstname varchar(45), @age int, @phone bigint

	DECLARE memb_cusror  CURSOR FOR
		SELECT member_id, lastname, firstname, age, phonenumber FROM memberinfo WHERE age = @AgeParam;

	OPEN memb_cusror 

	FETCH NEXT FROM memb_cusror INTO @memb_id , @lastname , @firstname , @age, @phone;

	Print '	' + 'Member_id	firstname	lastname   age	Phonenumber'

	WHILE @@FETCH_STATUS = 0
	BEGIN
		print '	' + CAST(@memb_id as varchar(45)) + '		' + CAST(@firstname as varchar(45))+ '		' + CAST(@lastname as varchar(45))+ '		' + CAST(@age as varchar(45)) + '		'+CAST(@phone as varchar(45))
	
		FETCH NEXT FROM memb_cusror INTO @memb_id , @lastname , @firstname , @age, @phone;
	END
	CLOSE memb_cusror;
	DEALLOCATE memb_cusror;

END

EXEC sp_displayMemberInfo 30;

drop proc sp_displayMemberInfo


-- LAB 16 --
drop trigger tg_addMember

CREATE TRIGGER tg_addMember ON memberinfo
INSTEAD of INSERT
AS
BEGIN
	DECLARE @email varchar(45)
	SELECT @email = email FROM inserted
	IF not exists(SELECT * FROM memberinfo WHERE email=@email)
	BEGIN
		INSERT INTO memberinfo (member_id,email) SELECT member_id,email FROM inserted
	END
	ELSE
	BEGIN
		print'Email Id already exists...'
	END
END

SELECT * FROM memberinfo

INSERT INTO memberinfo values ('M505', 'Rakesh', 'Rakesh','Thakur', 22, 'Male', 'R@gmail.com','1234567890')



-- LAB 17 --
drop trigger tg_memberTable

CREATE TRIGGER tg_memberTable ON memberinfo
FOR INSERT,UPDATE,DELETE
AS
BEGIN
	DECLARE @id varchar(45)
	DECLARE @operation varchar(45)
	IF exists(SELECT * FROM inserted)
	BEGIN
		IF exists(SELECT * FROM inserted)
		BEGIN
			SELECT @id=member_id FROM inserted
			SELECT @operation='Updated...'
		END
	ELSE
	BEGIN
		SELECT @id=member_id FROM inserted;
		SELECT @operation='Inserted...'
	END
	END
	ELSE IF exists(SELECT * FROM deleted)
	BEGIN
		SELECT @id=member_id FROM deleted;
		SELECT @operation='Deleted...'
	END
	ELSE IF exists(SELECT * FROM updated)
	BEGIN
		SELECT @id=member_id FROM updated;
		SELECT @operation='Updated...'
	END


	INSERT INTO memberLog VALUES(GETDATE(),@id,@operation,'   ')
	print'Operation successful'
END

CREATE TABLE  memberLog(change_date date,member_id varchar(45),operation varchar(45),description varchar(50))

SELECT * FROM memberinfo
SELECT * FROM memberLog
INSERT INTO memberinfo VALUES('M506', 'Rakesh', 'Rakesh','Thakur', 22, 'Male', 'Rakesh@gmail.com','1234567890')


-- LAB 18 --
drop trigger memberLogTrigger

CREATE TRIGGER memberLogTrigger ON memberinfo
FOR INSERT,UPDATE,DELETE
AS
BEGIN
	DECLARE @id varchar(45)
	DECLARE @operation varchar(45)
	DECLARE @desc varchar(45)
	IF exists(SELECT * FROM inserted)
	BEGIN
		IF exists(SELECT * FROM inserted)
		BEGIN
			SELECT @id=member_id FROM inserted
			SELECT @operation = 'Updated...'
			SELECT @desc = 'Member Details Updated...'
		END
	ELSE
	BEGIN
		SELECT @id=member_id FROM inserted;
		SELECT @operation='Inserted...'
		SELECT @desc = 'Member Details Inserted...'
	END
	END
	
	ELSE IF exists(SELECT * FROM deleted)
	BEGIN
		SELECT @id=member_id FROM deleted;
		SELECT @operation='Deleted...'
		SELECT @desc = 'Member Details Deleted...'
	END


	INSERT INTO memberLog VALUES(GETDATE(),@id,@operation, @desc)
	print'successful...'
END

UPDATE memberinfo SET gender = '0' WHERE member_id = 'M1';
SELECT * FROM memberinfo
DELETE FROM memberinfo WHERE member_id = 'M501';
SELECT * FROM memberLog
