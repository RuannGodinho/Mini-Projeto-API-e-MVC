# Mini-Projeto-API-e-MVC para realizar um CRUD de Produtos.

Utilizei ASP.NET MVC em conjunto com o Entityframework na versão 3.1 .Net Core para o WebApp, na parte da api utilizei swagger para documentação e mais facil utilização.
Usei o  Metodo Code-First, comecei criando a classe de produtos na pasta Models preenchendo a entidade de Produto com :Nome, Estoque e Valor, depois criei a classe context
para setar o banco de dados, tambem usei o Migrations para auxiliar.
Depois criei a Controller dos produtos e fiz a ordenação dos produtos no Index por diferentes campos, e a busca de um produto pelo nome.


*Sobre a parte bonus, tentei fazer o teste com xUnit, acabei não conseguindo mas o projeto e o codigo ainda estao lá caso queiram dar uma olhada :), não está afetando
em nada no projeto.*


Pacotes Nuget Utilizados:
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.Net.Test.Sdk
Swashbuckle.AspNetCore
PagedList
Moq
xunit
xunit.core
xunit.assert
