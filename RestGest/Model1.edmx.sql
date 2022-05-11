
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/11/2022 21:39:55
-- Generated from EDMX file: C:\Users\ruben\source\repos\DA_Proejto\PSI_DA_PL_D\RestGest\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RestGestDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PessoaMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas] DROP CONSTRAINT [FK_PessoaMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Restaurantes] DROP CONSTRAINT [FK_RestauranteMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteItemMenu_Restaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RestauranteItemMenu] DROP CONSTRAINT [FK_RestauranteItemMenu_Restaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteItemMenu_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RestauranteItemMenu] DROP CONSTRAINT [FK_RestauranteItemMenu_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoItemMenu_Pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoItemMenu] DROP CONSTRAINT [FK_PedidoItemMenu_Pedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoItemMenu_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoItemMenu] DROP CONSTRAINT [FK_PedidoItemMenu_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_EstadoPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoRestaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_PedidoRestaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_TrabalhadorRestaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_TrabalhadorRestaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientePedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_ClientePedido];
GO
IF OBJECT_ID(N'[dbo].[FK_TrabalhadorPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_TrabalhadorPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentos] DROP CONSTRAINT [FK_PedidoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_PagamentoMetodoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentos] DROP CONSTRAINT [FK_PagamentoMetodoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenus] DROP CONSTRAINT [FK_ItemMenuCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros] DROP CONSTRAINT [FK_CarroCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Servicos] DROP CONSTRAINT [FK_CarroServico];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoParcela]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parcelas] DROP CONSTRAINT [FK_ServicoParcela];
GO
IF OBJECT_ID(N'[dbo].[FK_Trabalhador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_Trabalhador_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Pessoas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas];
GO
IF OBJECT_ID(N'[dbo].[Restaurantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurantes];
GO
IF OBJECT_ID(N'[dbo].[ItemMenus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenus];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Pedidos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pedidos];
GO
IF OBJECT_ID(N'[dbo].[Pagamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagamentos];
GO
IF OBJECT_ID(N'[dbo].[Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estados];
GO
IF OBJECT_ID(N'[dbo].[MetodoPagamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetodoPagamentos];
GO
IF OBJECT_ID(N'[dbo].[Moradas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Moradas];
GO
IF OBJECT_ID(N'[dbo].[Carros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros];
GO
IF OBJECT_ID(N'[dbo].[Cliente1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cliente1];
GO
IF OBJECT_ID(N'[dbo].[Parcelas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parcelas];
GO
IF OBJECT_ID(N'[dbo].[Servicos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servicos];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Trabalhador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Trabalhador];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Cliente];
GO
IF OBJECT_ID(N'[dbo].[RestauranteItemMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RestauranteItemMenu];
GO
IF OBJECT_ID(N'[dbo].[PedidoItemMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidoItemMenu];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'Restaurantes'
CREATE TABLE [dbo].[Restaurantes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenus'
CREATE TABLE [dbo].[ItemMenus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fotografia] nvarchar(max)  NOT NULL,
    [Ingredientes] nvarchar(max)  NOT NULL,
    [Preco] float  NOT NULL,
    [Ativo] bit  NOT NULL,
    [CategoriaId] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Pedidos'
CREATE TABLE [dbo].[Pedidos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ValorTotal] float  NOT NULL,
    [EstadoId] int  NOT NULL,
    [RestauranteId] int  NOT NULL,
    [ClienteId] int  NOT NULL,
    [TrabalhadorId] int  NOT NULL
);
GO

-- Creating table 'Pagamentos'
CREATE TABLE [dbo].[Pagamentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor] float  NOT NULL,
    [PedidoId] int  NOT NULL,
    [MetodoPagamentoId] int  NOT NULL
);
GO

-- Creating table 'Estados'
CREATE TABLE [dbo].[Estados] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Estad] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MetodoPagamentos'
CREATE TABLE [dbo].[MetodoPagamentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MetodoPagament] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Moradas'
CREATE TABLE [dbo].[Moradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Carros'
CREATE TABLE [dbo].[Carros] (
    [IdCarro] int IDENTITY(1,1) NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Cliente1'
CREATE TABLE [dbo].[Cliente1] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] int  NOT NULL
);
GO

-- Creating table 'Parcelas'
CREATE TABLE [dbo].[Parcelas] (
    [IdParcelas] int IDENTITY(1,1) NOT NULL,
    [Valor] float  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [ServicoIdServico] int  NOT NULL
);
GO

-- Creating table 'Servicos'
CREATE TABLE [dbo].[Servicos] (
    [IdServico] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [CarroIdCarro] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Trabalhador'
CREATE TABLE [dbo].[Pessoas_Trabalhador] (
    [Salario] float  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [RestauranteId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [TotalGasto] float  NOT NULL,
    [NumContribuinte] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'RestauranteItemMenu'
CREATE TABLE [dbo].[RestauranteItemMenu] (
    [Restaurantes_Id] int  NOT NULL,
    [ItemMenus_Id] int  NOT NULL
);
GO

-- Creating table 'PedidoItemMenu'
CREATE TABLE [dbo].[PedidoItemMenu] (
    [Pedidos_Id] int  NOT NULL,
    [ItemMenus_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [PK_Restaurantes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemMenus'
ALTER TABLE [dbo].[ItemMenus]
ADD CONSTRAINT [PK_ItemMenus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [PK_Pedidos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [PK_Pagamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Estados'
ALTER TABLE [dbo].[Estados]
ADD CONSTRAINT [PK_Estados]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetodoPagamentos'
ALTER TABLE [dbo].[MetodoPagamentos]
ADD CONSTRAINT [PK_MetodoPagamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Moradas'
ALTER TABLE [dbo].[Moradas]
ADD CONSTRAINT [PK_Moradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carros'
ALTER TABLE [dbo].[Carros]
ADD CONSTRAINT [PK_Carros]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCliente] in table 'Cliente1'
ALTER TABLE [dbo].[Cliente1]
ADD CONSTRAINT [PK_Cliente1]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdParcelas] in table 'Parcelas'
ALTER TABLE [dbo].[Parcelas]
ADD CONSTRAINT [PK_Parcelas]
    PRIMARY KEY CLUSTERED ([IdParcelas] ASC);
GO

-- Creating primary key on [IdServico] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [PK_Servicos]
    PRIMARY KEY CLUSTERED ([IdServico] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [PK_Pessoas_Trabalhador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Restaurantes_Id], [ItemMenus_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [PK_RestauranteItemMenu]
    PRIMARY KEY CLUSTERED ([Restaurantes_Id], [ItemMenus_Id] ASC);
GO

-- Creating primary key on [Pedidos_Id], [ItemMenus_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [PK_PedidoItemMenu]
    PRIMARY KEY CLUSTERED ([Pedidos_Id], [ItemMenus_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Morada_Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [FK_PessoaMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaMorada'
CREATE INDEX [IX_FK_PessoaMorada]
ON [dbo].[Pessoas]
    ([Morada_Id]);
GO

-- Creating foreign key on [Morada_Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [FK_RestauranteMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteMorada'
CREATE INDEX [IX_FK_RestauranteMorada]
ON [dbo].[Restaurantes]
    ([Morada_Id]);
GO

-- Creating foreign key on [Restaurantes_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_Restaurante]
    FOREIGN KEY ([Restaurantes_Id])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenus_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenus_Id])
    REFERENCES [dbo].[ItemMenus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteItemMenu_ItemMenu'
CREATE INDEX [IX_FK_RestauranteItemMenu_ItemMenu]
ON [dbo].[RestauranteItemMenu]
    ([ItemMenus_Id]);
GO

-- Creating foreign key on [Pedidos_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [FK_PedidoItemMenu_Pedido]
    FOREIGN KEY ([Pedidos_Id])
    REFERENCES [dbo].[Pedidos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenus_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [FK_PedidoItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenus_Id])
    REFERENCES [dbo].[ItemMenus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoItemMenu_ItemMenu'
CREATE INDEX [IX_FK_PedidoItemMenu_ItemMenu]
ON [dbo].[PedidoItemMenu]
    ([ItemMenus_Id]);
GO

-- Creating foreign key on [EstadoId] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_EstadoPedido]
    FOREIGN KEY ([EstadoId])
    REFERENCES [dbo].[Estados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoPedido'
CREATE INDEX [IX_FK_EstadoPedido]
ON [dbo].[Pedidos]
    ([EstadoId]);
GO

-- Creating foreign key on [RestauranteId] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_PedidoRestaurante]
    FOREIGN KEY ([RestauranteId])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoRestaurante'
CREATE INDEX [IX_FK_PedidoRestaurante]
ON [dbo].[Pedidos]
    ([RestauranteId]);
GO

-- Creating foreign key on [RestauranteId] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_TrabalhadorRestaurante]
    FOREIGN KEY ([RestauranteId])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhadorRestaurante'
CREATE INDEX [IX_FK_TrabalhadorRestaurante]
ON [dbo].[Pessoas_Trabalhador]
    ([RestauranteId]);
GO

-- Creating foreign key on [ClienteId] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_ClientePedido]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientePedido'
CREATE INDEX [IX_FK_ClientePedido]
ON [dbo].[Pedidos]
    ([ClienteId]);
GO

-- Creating foreign key on [TrabalhadorId] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_TrabalhadorPedido]
    FOREIGN KEY ([TrabalhadorId])
    REFERENCES [dbo].[Pessoas_Trabalhador]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhadorPedido'
CREATE INDEX [IX_FK_TrabalhadorPedido]
ON [dbo].[Pedidos]
    ([TrabalhadorId]);
GO

-- Creating foreign key on [PedidoId] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [FK_PedidoPagamento]
    FOREIGN KEY ([PedidoId])
    REFERENCES [dbo].[Pedidos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoPagamento'
CREATE INDEX [IX_FK_PedidoPagamento]
ON [dbo].[Pagamentos]
    ([PedidoId]);
GO

-- Creating foreign key on [MetodoPagamentoId] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [FK_PagamentoMetodoPagamento]
    FOREIGN KEY ([MetodoPagamentoId])
    REFERENCES [dbo].[MetodoPagamentos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoMetodoPagamento'
CREATE INDEX [IX_FK_PagamentoMetodoPagamento]
ON [dbo].[Pagamentos]
    ([MetodoPagamentoId]);
GO

-- Creating foreign key on [CategoriaId] in table 'ItemMenus'
ALTER TABLE [dbo].[ItemMenus]
ADD CONSTRAINT [FK_ItemMenuCategoria]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuCategoria'
CREATE INDEX [IX_FK_ItemMenuCategoria]
ON [dbo].[ItemMenus]
    ([CategoriaId]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'Carros'
ALTER TABLE [dbo].[Carros]
ADD CONSTRAINT [FK_CarroCliente]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Cliente1]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroCliente'
CREATE INDEX [IX_FK_CarroCliente]
ON [dbo].[Carros]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [CarroIdCarro] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [FK_CarroServico]
    FOREIGN KEY ([CarroIdCarro])
    REFERENCES [dbo].[Carros]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroServico'
CREATE INDEX [IX_FK_CarroServico]
ON [dbo].[Servicos]
    ([CarroIdCarro]);
GO

-- Creating foreign key on [ServicoIdServico] in table 'Parcelas'
ALTER TABLE [dbo].[Parcelas]
ADD CONSTRAINT [FK_ServicoParcela]
    FOREIGN KEY ([ServicoIdServico])
    REFERENCES [dbo].[Servicos]
        ([IdServico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoParcela'
CREATE INDEX [IX_FK_ServicoParcela]
ON [dbo].[Parcelas]
    ([ServicoIdServico]);
GO

-- Creating foreign key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------