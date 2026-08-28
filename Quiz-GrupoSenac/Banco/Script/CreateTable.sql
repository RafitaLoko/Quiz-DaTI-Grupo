
create table Usuario (
Id serial primary key,
Nome varchar(100) not null,
Nick varchar(50) unique not null,
DataNascimento date not null,
Senha varchar(255) not null,
Tipo varchar(20) not null default 'Aluno'
);

create table UsuarioRanking (
UsuarioId int not null,
PontuacaoTotal int not null default 0,
NumeroAcertos int not null default 0,
totalPerguntasRespondidas int not null,
acertoConsecutivo int not null,
temamaisAcertado varchar(100) not null
constraint FK_UsuarioRanking_Usuario
foreign key (UsuarioId)
references Usuario(Id)
);

create table Pergunta (
Id serial primary key,
Enunciado text not null,
Tipo varchar(20) not null,
Nivel varchar(20) not null,
Tema varchar(50) not null,
pontuacao int not null
);

create table Alternativa (
Id serial primary key,
PerguntaId int not null,
Texto text not null,
correta boolean not null,
constraint FK_Alternativa_Pergunta 
foreign key (PerguntaId)
references Pergunta(Id)
);

create table Partida (
Id serial primary key,
UsuarioId int not null,
DataHora timestamp not null default 
current_timestamp,
Pontuacao int not null default 0,
constraint FK_Partida_Usuario
foreign key (UsuarioId)
references Usuario(Id)
);


create table Resposta (
Id serial primary key,
PartidaId int not null,
PerguntaId int not null,
Acertou boolean not null,
PontuacaoGanha int not null default 0,
constraint FK_Resposta_Partida
foreign key (PartidaId)
references Partida(Id),
constraint FK_Resposta_Pergunta
foreign key (PerguntaId)
references Pergunta(Id)
);


create table Conquistas (
Id serial primary key,
Nome varchar(100) not null,
Descricao text not null,
Icone varchar(255)
);


create table UsuarioConquista (
Id serial primary key,
UsuarioId int not null,
ConquistasId int not null,
DataConquista timestamp not null default
current_timestamp,
foreign key (UsuarioId)
references Usuario(Id),
foreign key (ConquistasId)
references Conquistas(Id)
);


insert into pergunta 
(enunciado, tipo, nivel, tema, pontuacao)
values (
'Qual componente é responsável pelo processamento do computador?',
'Alternativas',
'Fácil',
'Hardware',
20
);

insert into alternativa 
(perguntaid, texto, correta)
values 
(1, 'Monitor', false),
(1, 'Teclado', false),
(1, 'Processador', true),
(1, 'Mouse', false);

select * from pergunta p 



              SELECT 
                p.Id,
                p.Enunciado,
                p.Tipo,
                p.Nivel,
                p.Tema,
                p.Pontuacao,

                a.Id,
                a.PerguntaId,
                a.Texto,
                a.Correta

              FROM Pergunta p

              INNER JOIN Alternativa a
                ON a.PerguntaId = p.Id

               WHERE p.Id IN
              (
                SELECT Id
                FROM Pergunta
                WHERE Nivel = 'Avançado'
                ORDER BY RANDOM()
                LIMIT 1
              )

              OR p.Id IN
              (
                SELECT Id
                FROM Pergunta
                WHERE Nivel <> 'Avançado'
                ORDER BY RANDOM()
                LIMIT 9
              )

              ORDER BY p.Id;

