# Framework Challenge

Projeto produzido para o desafio técnico do processo seletivo da Framework.

O objetivo desse projeto foi desenvolver uma aplicação que consiste em um Menu para acessar 3 telas, em que cada tela contém uma tabela para listar POSTAGENS, ÁLBUNS e TO-DOs. Os dados da tabela são preenchidos acessando-se a API publicada em https://jsonplaceholder.typicode.com/.

Para cada uma dessas 3 telas, os endpoints de "posts", "albums" e "todos" deveriam ser acessados para recuperar um JSON com os dados a serem preenchidos nas tabelas.

A aplicação foi desenvolvida utilizando a linguagem C# (.NET Framework 4.7.2). A biblioteca open source Json.NET foi utilizada para desserialização.

Para compilar a aplicação, é necessário possuir o Visual Studio 2019 instalado. Então segue-se os passos:

 1. Clone o repositório;
 2. Abra o arquivo FrameworkChallenge.sln com o Visual Studio;
 3. Selecione a configuração Debug (para depuração) ou Release;
 4. No menu superior, clique em Compilação > Compilar Solução.

Para executar, basta pressionar F5 (modo de depuração) ou Ctrl+F5.

Caso não possua o Visual Studio instalado, é possível compilar o código seguindo os seguintes passos (não testado):

1. Baixe o [.NET Framework 4.7.2 Developer Pack](https://go.microsoft.com/fwlink/?linkid=874338);
2. Baixe o [NuGet](https://dist.nuget.org/win-x86-commandline/latest/nuget.exe) para instalação do pacote Json.NET;
3. Clone o repositório e copie o `NuGet.exe` para o diretório da solução;
4. Abra um prompt de comando e altere o diretório de trabalho para o do repositório clonado (Ex. `cd C:\Users\Me\Documents\FrameworkChallenge`);
5. Execute o `NuGet.exe` para baixar o pacote necessário: `NuGet.exe install FrameworkChallenge/packages.config -o packages/`
6. Altere o diretório de trabalho para o de instalação do .NET Framework Developer Pack: `cd C:\Windows\Microsoft.NET\Framework\v4*`
7. Use o `MSBuild.exe` para compilar a solução: `msbuild C:\Users\Me\Documents\FrameworkChallenge\FrameworkChallenge.sln /t:Rebuild /p:Configuration=Release /p:Platform="Any CPU"`. Lembre-se de substituir o diretório para o diretório real em que o projeto está localizado em seu computador.