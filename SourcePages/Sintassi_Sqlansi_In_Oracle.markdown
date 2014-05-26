
##  Scenario 
* Oracle dalla versione 9i in avanti ha iniziato a supportare le varie versioni dell'ANSI/ISO SQL
    * Oracle 9.2 supporta sql ansi 92 e parzialmente sql ansi 99
    * Oracle 10.2 supporta parzialmente sql ansi 2003
    * Da documentazione ufficiale Oracle **"...Oracle recommends that you use the FROM clause OUTER JOIN syntax rather than the Oracle join operator..."**
* Presentazione Oracle Ansi SQL con particolare riguardo alla sintassi delle join:
    * [Slides Briefing Sviluppo Apex-net 03/03/2006 - Sql ANSI in Oracle](../Upload/SlidesSqlAnsi.zip)

##  Esempi 
* **FULL OUTER Join**

`{{'''Traditional Syntax''':
SELECT
      d.department_id,
      d.department_name,
      COUNT(e.employee_id) "Employees"
     FROM
      departments d,
      employees e
    WHERE d.department_id = e.department_id (+) 
    GROUP BY d.department_id, d.department_name
UNION
   SELECT
      d.department_id,
      d.department_name,
      COUNT(e.employee_id) "Employees"
     FROM
      departments d,
      employees e
    WHERE d.department_id (+) = e.department_id
    GROUP BY d.department_id, d.department_name;

'''ANSI Syntax''':
SELECT
   d.department_id,
   d.department_name,
   COUNT(e.employee_id) "Employees"
  FROM
   employees e FULL OUTER JOIN departments d 
   ON d.department_id = e.department_id
 GROUP BY d.department_id, d.department_name
 ORDER BY d.department_id, d.department_name;
 `}}

##  Links 
* [Getting ANSI About Joins](http://www.dbasupport.com/oracle/ora9i/ansi_joins.shtml )
* [Oracle and Standard SQL](http://download-uk.oracle.com/docs/cd/B19306_01/server.102/b14200/ap_standard_sql.htm )
* [Studio comparativo delle diverse implementazioni SQL in Oracle, Sqlserver, DB2, Mysql, PostgreSQL](http://troels.arvin.dk/db/rdbms )
* [SQL Reference Page](http://star.mfn.unipmn.it/Document/Postgresql/sql/sqlref.htm#sql92 )
* [W3Schools](http://www.w3schools.com/sql/sql_functions.asp )
* [Oracle / SQL Server / DB2 / Mckoi / MySQL Database Equivalents](http://www.aronson.co.il/DbEquiv.php )

