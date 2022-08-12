Projeto console  de Insercão em um banco SQLSERVER .NET(6.0)

3 campos usado para a inserção
Id int(pk)
Nome varchar(300)
Data_da_criacao(datetime)


![image](https://user-images.githubusercontent.com/82232439/184281705-3f32846b-25bf-4c12-936d-59d7b01f3786.png)


Query usada 
string insertQuery = "INSERT INTO COLLABORATOR(Nome,Data_da_Criacao) VALUES('" + colob.Nome + "'," + "'" + colob.dataDeCriacao + "'" + ")";


Console:
![image](https://user-images.githubusercontent.com/82232439/184282792-d40a1291-b10e-4eac-8d5c-e772db82242d.png)


DB:
![image](https://user-images.githubusercontent.com/82232439/184282847-6f2dee9c-f928-4982-b23c-8507b3ffb7b6.png)
