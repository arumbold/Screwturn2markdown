
##  Scenario 
* If you don't enable SET ANSI_PADDING ON, SQL Server trims trailing blanks for variable-length columns and for fixed-length columns that allow NULLs. The reeason seems to be compatibility with legacy (pre 6.5) versions of SQL Server. 

##  SET ANSI_PADDING (Transact-SQL) 
* This setting controls the way the column stores values shorter than the defined size of the column, and the way the column stores values that have trailing blanks in char, varchar, binary, and varbinary data.
* When set to ON, trailing blanks in character values inserted into varchar columns and trailing zeros in binary values inserted into varbinary columns are not trimmed. Values are not padded to the length of the column. When set to OFF, the trailing blanks (for varchar) and zeros (for varbinary) are trimmed. This setting affects only the definition of new columns.
* **It is recommended that ANSI_PADDING always be set to ON.** SET ANSI_PADDING must be ON when creating or manipulating indexes on computed columns or indexed views.
* The status of this option can be determined by examining the IsAnsiPaddingEnabled property of the DATABASEPROPERTYEX function. 
* This setting affects only the definition of new columns. **After the column is created, SQL Server 2005 stores the values based on the setting when the column was created.** Existing columns are not affected by a later change to this setting.

##  Importante 
* In a future version of SQL Server **ANSI_PADDING will always be ON and any applications that explicitly set the option to OFF will produce an error**. Avoid using this feature in new development work, and plan to modify applications that currently use this feature.

##  Sintassi 
SET ANSI_PADDING { ON | OFF }

##  Esempi 
* **The following example shows how the setting affects each of these data types.**

`{{'''With ANSI_PADDING ON''':
PRINT 'Testing with ANSI_PADDING ON'
SET ANSI_PADDING ON;
GO

CREATE TABLE t1 (
   charcol CHAR(16) NULL, 
   varcharcol VARCHAR(16) NULL, 
   varbinarycol VARBINARY(8)
);
GO
INSERT INTO t1 VALUES ('No blanks', 'No blanks', 0x00ee);
INSERT INTO t1 VALUES ('Trailing blank ', 'Trailing blank ', 0x00ee00);

SELECT 'CHAR' = '>' + charcol + '<', 'VARCHAR'='>' + varcharcol + '<',
   varbinarycol
FROM t1;
GO

'''With ANSI_PADDING OFF''':
PRINT 'Testing with ANSI_PADDING OFF';
SET ANSI_PADDING OFF;
GO

CREATE TABLE t2 (
   charcol CHAR(16) NULL, 
   varcharcol VARCHAR(16) NULL, 
   varbinarycol VARBINARY(8)
);
GO
INSERT INTO t2 VALUES ('No blanks', 'No blanks', 0x00ee);
INSERT INTO t2 VALUES ('Trailing blank ', 'Trailing blank ', 0x00ee00);

SELECT 'CHAR' = '>' + charcol + '<', 'VARCHAR'='>' + varcharcol + '<',
   varbinarycol
FROM t2;
GO

DROP TABLE t1
DROP TABLE t2
`}}


##  Riferimenti 
* [SQL Server 2005 Books Online: SET ANSI_PADDING (Transact-SQL)](http://msdn2.microsoft.com/en-us/library/ms187403.aspx )
* [The Joel on Software Discussion Group: Why does SQL Server do this?](http://discuss.joelonsoftware.com/default.asp?joel.3.66884.22 )
