import React from "react";

const Sobre = () => {
  return (
    <div>
      <h1>Meu nome é Deivid Veloso</h1>
      <p>
        <p>Esse projeto foi desenvolvido usando as seguintes tecnologias:</p>
        <p>Front-End: React e Redux.</p>
        <p>
          Back-End: C#, EntityFramework Core, Fluent API, FluentValidation, Asp.Net Core, com design de projetos DDD.
        </p>
      </p>
      <p>
          <h1>Instruções de uso Back-End</h1>
          <p>Usar o git clone no repositório.</p>
          <p>Buildar o projeto para baixar as dependências Nuget e gerar as dlls.</p>
          <p>Alterar a connectionstring do arquivo appsettings no projeto WEB.API.</p>
          <p>Rodar o comando Update-Database para gerar o banco de dados.</p>
      </p>
      <p>
          <h1>Instruções de uso Front-End</h1>
          <p>Usar o git clone no repositório.</p>
          <p>executar o comando npm install para instalar as depêndencias.</p>
          <p>executar o comando npm run dev para subir o projeto.</p>
        
      </p>
      <h1>Repositório</h1>
      <h2>Front-end: https://bitbucket.org/DeividVeloso/desafio.ui</h2>
      <h2>Back-end: https://bitbucket.org/DeividVeloso/desafio</h2>
    </div>
  );
};
export default Sobre;
