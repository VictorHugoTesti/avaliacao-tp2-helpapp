# 📘 Avaliação Técnica – Clean Architecture + SQL Server Local

Este repositório contém minha entrega referente à avaliação técnica baseada no repositório original do professor:  
[https://github.com/victoricoma/avaliacao-tp2-helpapp](https://github.com/victoricoma/avaliacao-tp2-helpapp)

---

## ✅ Objetivo

Implementar os repositórios `Category` e `Product` seguindo os padrões da Clean Architecture, aplicar a migration `Initial` e conectar a aplicação com uma instância de SQL Server Local.

---

## 🚀 Funcionalidades implementadas

- [x] Repositórios `CategoryRepository` e `ProductRepository`
- [x] Configurações com `EntityTypeConfiguration` para `Category` e `Product`
- [x] Injeção de dependência configurada (`DependencyInjectionAPI`)
- [x] Migration `Initial` criada com `HasData()` para categorias
- [x] Banco de dados SQL Server Local
- [x] Migration aplicada com sucesso no SLQ Server via `Packge Manager Console`

---
# 🔧 Comandos utilizados
## Criação da migration
Add-Migration Initial

## Aplicação no banco de dados (Local)
Update-Database


# 🔗 String de conexão (mascarada)

"ConnectionStrings": {
  "DefaultConnection": "Data Source= VICTOR-HUGO\\SQLEXPRESS;Initial Catalog=avaliacao_tpII;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"
}

# Configuração SQL Server Local

**Banco de dados nomeado:** avaliacao_tpII


# 🖼️ Prints de evidência (opcional)
Insira prints aqui comprovando:

**Testes Unitários:**
![image](https://github.com/user-attachments/assets/1e9e6260-1d46-45ef-accd-fe29d2bcfcc6)

**Criação do Bando de Dados Local e Tabelas e dados populados:**
![image](https://github.com/user-attachments/assets/39066d44-5db0-4c7c-9256-6c248ce086ef)

# 👨‍💻 Dados do aluno
Nome: Victor Hugo Malipense Testi

Curso: Desenvolvimento de Software Multiplataforma – 3º Semestre

Professor: Victor Icoma

Branch da entrega: avaliacao-VictorHugoTesti

## 🧱 Estrutura da aplicação

```bash
📦 HellpApp
 ┣ 📂 HelpApp.API
 ┣ 📂 HelpApp.Application
 ┣ 📂 HelpApp.Domain
 ┃ ┣ 📂 Entities
 ┃ ┣ 📂 Interfaces
 ┃ ┣ 📂 Validation
 ┣ 📂 HelpApp.Domain.Test
 ┣ 📂 HelpApp.Infra.Data
 ┃ ┣ 📂 Context
 ┃ ┣ 📂 EntitiesConfiguratios
 ┃ ┣ 📂 Migrations
 ┃ ┣ 📂 Repositories
 ┗ 📂 HelpApp.Infra.IoC

