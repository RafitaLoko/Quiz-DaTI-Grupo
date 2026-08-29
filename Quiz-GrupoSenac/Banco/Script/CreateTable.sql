
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






              INSERT INTO Pergunta (Enunciado, Tipo, Nivel, Tema, Pontuacao)
VALUES
('Qual destes dispositivos é utilizado para armazenar dados permanentemente?', 'Alternativas', 'Iniciante', 'Hardware', 10),

('Qual linguagem é muito utilizada para desenvolver aplicações web?', 'Alternativas', 'Fácil', 'Programação', 20),

('Qual equipamento é responsável por encaminhar dados entre diferentes redes?', 'Alternativas', 'Intermediário', 'Redes', 30),

('Qual atitude ajuda a proteger uma conta contra acessos não autorizados?', 'Alternativas', 'Fácil', 'Segurança Digital', 20),

('Qual destes é um sistema operacional?', 'Alternativas', 'Iniciante', 'Sistemas Operacionais', 10),

('Qual ferramenta é utilizada principalmente para criar apresentações?', 'Alternativas', 'Iniciante', 'Ferramentas de produtividade', 10),

('O que significa HTTPS em um endereço de site?', 'Alternativas', 'Intermediário', 'Segurança Digital', 30),

('Qual estrutura de programação é utilizada para repetir um bloco de código?', 'Alternativas', 'Intermediário', 'Programação', 30),

('Qual tecnologia permite conectar dispositivos a uma rede sem utilizar cabos?', 'Alternativas', 'Avançado', 'Redes', 50);



INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(2, 'HD/SSD', TRUE),
(2, 'Monitor', FALSE),
(2, 'Teclado', FALSE),
(2, 'Mouse', FALSE);

INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(3, 'HTML', FALSE),
(3, 'CSS', FALSE),
(3, 'JavaScript', TRUE),
(3, 'SQL', FALSE);


INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(4, 'Roteador', TRUE),
(4, 'Teclado', FALSE),
(4, 'Monitor', FALSE),
(4, 'Impressora', FALSE);


INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(5, 'Usar a mesma senha em todos os sites', FALSE),
(5, 'Compartilhar a senha com amigos', FALSE),
(5, 'Usar uma senha forte e diferente', TRUE),
(5, 'Deixar a senha anotada publicamente', FALSE);


INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(6, 'Windows', TRUE),
(6, 'Google Chrome', FALSE),
(6, 'WhatsApp', FALSE),
(6, 'YouTube', FALSE);


INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(7, 'PowerPoint', TRUE),
(7, 'Calculadora', FALSE),
(7, 'Bloco de Notas', FALSE),
(7, 'Gerenciador de Arquivos', FALSE);


INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(8, 'Uma conexão sem criptografia', FALSE),
(8, 'Um protocolo que utiliza criptografia para proteger a comunicação', TRUE),
(8, 'Um tipo de antivírus', FALSE),
(8, 'Um sistema operacional', FALSE);

INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(9, 'if', FALSE),
(9, 'for', TRUE),
(9, 'class', FALSE),
(9, 'return', FALSE);

INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(10, 'Bluetooth', FALSE),
(10, 'Wi-Fi', TRUE),
(10, 'HDMI', FALSE),
(10, 'USB', FALSE);




