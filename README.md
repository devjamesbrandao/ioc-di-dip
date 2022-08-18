<h1 align="center"><strong>Estudos sobre IoC, DI e DIP</strong></h1>

<hr/>

<p align="center">
    <img src="/img/dependencia.png" alt="O que é dependência (acoplamento) em programação?" title="O que é dependência (acoplamento) em programação?">
</p> 

<p align="center">
    <img src="/img/diminuir-dependencia.png" alt="Estratégia para diminuir o acoplamento" title="Estratégia para diminuir o acoplamento">
</p> 

### ` 🔍 Sobre`

<p align="justify">Estudos sobre Inversão de Controle (IoC), Injeção de dependência (DI) e Princípio da Injeção de Dependência (DIP)</p>

### ` 📜 Notas`
<p><strong>Inversion of Control</strong> é um princípio de design de software. Ele afirma que devemos inverter o fluxo de contole da aplicação. Como resultado, temos um código mais modularizado e passível de ser reutilizado.</p>

<p><strong>DI (Dependency Injection)</strong> é uma técnica que auxilia na implementação de outro princípio de design chamado IoC. Segundo ela, uma entidade (classe) A pode depender da Entidade B, todavia não é responsabilidade da entidade A gerenciar a entidade B. Nesse caso, quem realiza esse processo é o DI.</p>

<p><strong>Dependency Inversion Principle (DIP)</strong> afirma que deve haver um maior desacoplamento entre as camadas visando depender mais de abstrações (interfaces) do que de implementações (classes concretas). </p>

#### ` Código sem Ioc, DI e DIP`
<p align="center">
    <img src="/img/codigo-ruim.png" alt="Código ruim" title="Código ruim">
</p> 

#### ` Código com IoC e DI`
<p align="center">
    <img src="/img/ioc-di-1.png" alt="Implementando IoC e DI" title="Implementando IoC e DI">
</p> 

<p align="center">
    <img src="/img/ioc-di-2.png" alt="Implementando IoC e DI" title="Implementando IoC e DI">
</p> 

<p align="center">
    <img src="/img/ioc-di-3.png" alt="Implementando IoC e DI" title="Implementando IoC e DI">
</p> 

#### ` Código com IoC, DI e DIP`
<p align="center">
    <img src="/img/dip-1.png" alt="Implementando IoC, DI e DIP" title="Implementando IoC, DI e DIP">
</p> 

<p align="center">
    <img src="/img/dip-2.png" alt="Implementando IoC, DI e DIP" title="Implementando IoC, DI e DIP">
</p> 

<p align="center">
    <img src="/img/dip-3.png" alt="Implementando IoC, DI e DIP" title="Implementando IoC, DI e DIP">
</p> 

### `🔎 Como utilizar?`
```

git clone https://github.com/devjamesbrandao/ioc-di-dip

dotnet restore

dotnet build

dotnet run

```
### ` 🌐 Referências`

#### Artigos
- <p> A quick intro to Dependency Injection: what it is, and when to use it: https://www.freecodecamp.org/news/a-quick-intro-to-dependency-injection-what-it-is-and-when-to-use-it-7578c84fa88f/</p>

- <p> Dependency Injection: https://balta.io/blog/dependency-injection</p>

- <p> Dependency Inversion Principle: https://balta.io/blog/dependency-inversion-principle</p>

- <p> Inversion of Control: https://balta.io/blog/inversion-of-control</p>