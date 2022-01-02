# Asp.CoreMVC
In this repository, all basic features of Asp.net Core are implemented on a beginner's level.


***Data base First Approach Migrations With Project***

open pakge manage console 

**Run this command:**

Scaffold-DbContext 'Data Source=Your Sql Server name; Initial Catalog=TestDB; Integrated Security=True' Microsoft.EntityFrameworkCore.SqlServer -outputDir Models/Database -DataAnnotations

**Update Database or create new table**

**Run Command:**

Scaffold-DbContext 'Data Source=Your Sql Server name; Initial Catalog=TestDB; Integrated Security=True' Microsoft.EntityFrameworkCore.SqlServer -outputDir Models/Database -DataAnnotations -Force
