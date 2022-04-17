![banner](https://user-images.githubusercontent.com/46844031/163735676-99c480cf-4fe9-48a3-84ad-aa75a09c6c61.jpg)


![Badge Parado](http://img.shields.io/static/v1?label=STATUS&message=Parado&color=red&style=for-the-badge)  ![Visual Studio Code Badge](https://img.shields.io/badge/Visual_Studio_Code-0078D4?style=for-the-badge&logo=visual%20studio%20code&logoColor=white)  ![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)  ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)


![GitHub last commit](https://img.shields.io/github/last-commit/DeBaFig/DIO-Projeto-Catalogo)  [![GitHub issues](https://img.shields.io/github/issues/DeBaFig/DIO-Projeto-Catalogo)](https://github.com/DeBaFig/DIO-Projeto-Catalogo/issues) [![GitHub forks](https://img.shields.io/github/forks/DeBaFig/DIO-Projeto-Catalogo)](https://github.com/DeBaFig/DIO-Projeto-Catalogo/network) [![GitHub stars](https://img.shields.io/github/stars/DeBaFig/DIO-Projeto-Catalogo)](https://github.com/DeBaFig/DIO-Projeto-Catalogo/stargazers) [![GitHub license](https://img.shields.io/github/license/DeBaFig/DIO-Projeto-Catalogo)](https://github.com/DeBaFig/DIO-Projeto-Catalogo/blob/main/LICENSE) 

<h1 align="center">Projeto Boot Camp Localiza - Catálogo de Filmes</h1>

Esse programa foi desenvolvido graças ao boot camp gratuíto da [Digital Innovation One](https://www.dio.me/) com parceria da [Localiza](https://www.localiza.com/brasil/pt-br). A proposta é práticar os conhecimentos em .NET/C# fazendo um catálogo de filmes, podendo ser expandido para outros tipos de catálogo. 

<!--ts-->
   * [Sobre](#sobre)
   * [Download e execução](#download-e-execução)
   * [Exemplos](#exemplos)
      * [Séries de TV](#séries-de-tv)
      * [Livros](#livros)
      * [Mangás](#mangás)
   * [Créditos](#créditos)
   * [Tecnologias](#tecnologias)
   * [Autora](#autora)
<!--te-->


## Sobre

Esse programa foi desenvolvido com ajuda do curso da DIO usando a linguagem de C# e .NET framework, a principal função é armazenar na memória volátil informações adicionadas de filmes, livros e mangás. O programa também tem recursos para listar os itens por ID e alterar o item.

## Download e execução

```bash
# Clone este repositório
$ git clone https://github.com/DeBaFig/DIO-Projeto-Catalogo.git

# Acesse a pasta do projeto no terminal/cmd
$ cd DIO-Projeto-Catalogo

# Execute a aplicação em modo de desenvolvimento
$ dotnet run
```
## Exemplos
<p align="center">
  <img src="https://user-images.githubusercontent.com/46844031/163734478-21d66466-afc2-4e55-b287-d1a1405909f6.gif" width="600"/>
</p>

Há 3 opções de catálogos que podem ser acessados, abaixo você pode encontrar alguns exemplos de cada um.

````
Bem vindo ao catalogo TudoQueQuiser

Informe a opção desejada:

1- Acessar Catálogo de Séries de TV
2- Acessar Catálogo de Livros
3- Acessar Catálogo de Mangás

0- Sair

````

### Séries de TV

As opções disponíveis são as seguintes: 

````
No catálogo de Series você pode encontar e registrar
as mais diversas séries de todas as plataformas.

Informe a opção desejada:

1-Listar Series
2-Adicionar Serie
3-Atualizar Serie
4-Excluir Serie
5-Visualizar Serie
0- Sair
````

#### Características

- Listar Séries mostra em forma numérica crescente baseado no ID.
- Cria ID de maneira sequencial e armazena as informações da série em questão, os generos de série já são pré-definidos e utilizam um enum para que seja selecionada a opção.
- Atualiza a Série toda, não apenas um campo dela.
- Excluir muda o status de ativo para excluido, portanto pode ser identificado, mas ignorado.
- Visualizar permite mostrar apenas um item em especifico e é buscado pelo ID.

### Livros

Livros e Séries de TV compartilham as mesmas caractéristica com uma unica adição de que os livros, ao adicionar ao catálogo você deve adicionar um nome de autor.

````
Digite o número referente ao gênero: 13
Digite o Título: exemplo-1
Digite a Descrição: exemplo-1
Digite o Ano de Lançamento: 2022
Digite o nome do Autor: exemplo-1

````

### Mangás

Assim como as demais opções acima os Mangás também compartilham as demais carácteristicas, o diferencial está nos cápitulos que tem/lidos. O programa gera uma barra de leitura com os mangás lidos/publicados.

````
#ID: 0
Título: exemplo-2
Status: Válido
Capítulos:10
|▓▓▓▓▓▓▓▓▓░░| Lidos: 8
__________________________________

````

## Créditos

[Curso DIO - 
Criando um APP simples de cadastro de séries em .NET](https://web.dio.me/)

[Repositorio Original](https://github.com/elizarp/dio-dotnet-poo-lab-2)
[Eliézer Zarpelão](https://github.com/eduardolfelix/dio-cad-series-filmes-simples.NET)

## Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

- [C#](https://docs.microsoft.com/bs-latn-ba/dotnet/csharp/)
- [.NET](https://docs.microsoft.com/en-us/dotnet/fundamentals/)

## Autora

**Denize**

It is not luck, it is hard work!

<img style="border-radius: 50%;" src="https://user-images.githubusercontent.com/46844031/163518939-915f6e15-200a-4e9c-9f54-9bee6beec89b.jpg" width="100px;" alt=""/>

Where to find me:

[![Twitter Badge](https://img.shields.io/badge/Twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/Dbassi91)   [![Linkedin Badge](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/dbfigueiredo/)   [![Gmail Badge](	https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white)](mailto:denize.f.bassi@gmail.com)   [![CodePen](https://img.shields.io/badge/Codepen-000000?style=for-the-badge&logo=codepen&logoColor=white)](https://codepen.io/debafig)   
[![Facebook Badge](https://img.shields.io/badge/Facebook-1877F2?style=for-the-badge&logo=facebook&logoColor=white)](https://www.facebook.com/d.bassi91/)   [![GitHub Badge](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/DeBaFig)   [![Instagram Badge](https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white)](https://www.instagram.com/bassidenize/)   [![About.me Badge](https://img.shields.io/badge/website-000000?style=for-the-badge&logo=About.me&logoColor=white)](https://about.me/denizefigueiredo/getstarted)   [![Whatsapp](https://img.shields.io/badge/WhatsApp-25D366?style=for-the-badge&logo=whatsapp&logoColor=white)](https://wa.me/qr/VMVHOV7CIFHYP1)
