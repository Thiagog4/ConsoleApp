Projeto console  de Insercão em um banco SQLSERVER .NET(6.0)

3 campos usado para a inserção
Id int(pk)
Nome varchar(300)
Data_da_criacao(datetime)


![image](https://user-images.githubusercontent.com/82232439/184281705-3f32846b-25bf-4c12-936d-59d7b01f3786.png)


Query usada 
string insertQuery = "INSERT INTO COLLABORATOR(Nome,Data_da_Criacao) VALUES('" + colob.Nome + "'," + "'" + colob.dataDeCriacao + "'" + ")";
