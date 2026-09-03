
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



INSERT INTO Pergunta
(Enunciado, Tipo, Nivel, Tema, Pontuacao)
VALUES

('Qual componente é responsável por executar instruções e realizar cálculos em um computador?',
'Alternativas', 'Fácil', 'Hardware', 20),

('Qual estrutura de programação é mais adequada quando queremos executar diferentes comandos dependendo de uma condição?',
'Alternativas', 'Intermediário', 'Programação', 30),

('O protocolo TCP garante a entrega dos dados de forma confiável e ordenada.',
'Verdadeiro ou Falso', 'Intermediário', 'Redes', 30),

('Qual prática oferece maior proteção contra ataques de força bruta em uma conta?',
'Alternativas', 'Avançado', 'Segurança Digital', 50),

('Qual sistema de arquivos é utilizado por padrão em muitas instalações modernas do Windows?',
'Alternativas', 'Fácil', 'Sistemas Operacionais', 20),

('Uma variável declarada dentro de um método pode ser acessada diretamente por qualquer outro método da mesma classe.',
'Verdadeiro ou Falso', 'Intermediário', 'Programação', 30),

('Qual dispositivo normalmente encaminha pacotes entre redes diferentes?',
'Alternativas', 'Intermediário', 'Redes', 30),

('Qual característica da memória RAM a diferencia de um SSD?',
'Alternativas', 'Avançado', 'Hardware', 50),

('Qual ferramenta é mais adequada para organizar dados em linhas e colunas e realizar cálculos?',
'Alternativas', 'Fácil', 'Ferramentas de produtividade', 20),

('Qual técnica é utilizada para transformar dados legíveis em uma informação codificada que só pode ser recuperada utilizando um mecanismo adequado?',
'Alternativas', 'Avançado', 'Segurança Digital', 50);


INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(1, 'Processador (CPU)', TRUE),
(1, 'Placa de vídeo', FALSE),
(1, 'Fonte de alimentação', FALSE),
(1, 'Monitor', FALSE);

INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(2, 'if/else', TRUE),
(2, 'import', FALSE),
(2, 'class', FALSE),
(2, 'return', FALSE);

INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(4, 'Usar uma senha curta', FALSE),
(4, 'Usar uma senha longa e autenticação multifator', TRUE),
(4, 'Usar a mesma senha em vários sites', FALSE),
(4, 'Desativar atualizações de segurança', FALSE);


INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(5, 'NTFS', TRUE),
(5, 'FAT12', FALSE),
(5, 'EXT2', FALSE),
(5, 'HFS+', FALSE);

INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(7, 'Roteador', TRUE),
(7, 'Teclado', FALSE),
(7, 'Monitor', FALSE),
(7, 'Scanner', FALSE);

INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(8, 'A RAM é uma memória volátil', TRUE),
(8, 'A RAM mantém os dados mesmo sem energia', FALSE),
(8, 'A RAM é usada exclusivamente para armazenamento permanente', FALSE),
(8, 'A RAM não pode ser acessada pelo processador', FALSE);

INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(9, 'Planilha eletrônica', TRUE),
(9, 'Editor de imagens', FALSE),
(9, 'Player de música', FALSE),
(9, 'Navegador GPS', FALSE);

INSERT INTO Alternativa (PerguntaId, Texto, Correta)
VALUES
(10, 'Criptografia', TRUE),
(10, 'Desfragmentação', FALSE),
(10, 'Formatação', FALSE),
(10, 'Compactação física do disco', FALSE);



alter table pergunta 
add column RespostaVF boolean;


update pergunta 
set RespostaVF = true 
where id = 3;

update pergunta 
set RespostaVF = false 
where id = 6;






INSERT INTO Pergunta
(Id, Enunciado, Tipo, Nivel, Tema, Pontuacao)
VALUES

(11,
'Em C#, qual é a principal diferença entre uma classe e uma interface?',
'Múltipla Escolha',
'Avançado',
'C#',
10),

(12,
'Em SQL, qual cláusula é utilizada para filtrar os resultados depois de uma função de agregação como COUNT ou AVG?',
'Múltipla Escolha',
'Avançado',
'Banco de Dados',
10),

(13,
'Qual é a finalidade principal de uma chave estrangeira em um banco de dados relacional?',
'Múltipla Escolha',
'Intermediário',
'Banco de Dados',
10),

(14,
'Em programação orientada a objetos, o que caracteriza o polimorfismo?',
'Múltipla Escolha',
'Avançado',
'Programação',
10),

(15,
'No Git, qual comando é utilizado para criar uma nova ramificação a partir da posição atual?',
'Múltipla Escolha',
'Intermediário',
'Git',
10),

(16,
'Em C#, o que acontece quando uma exceção não é tratada por nenhum bloco catch?',
'Múltipla Escolha',
'Avançado',
'C#',
10),

(17,
'Qual estrutura de dados segue o princípio LIFO, onde o último elemento inserido é o primeiro a sair?',
'Múltipla Escolha',
'Intermediário',
'Estrutura de Dados',
10),

(18,
'Em uma aplicação Windows Forms, qual é a finalidade principal de um evento Click de um botão?',
'Múltipla Escolha',
'Básico',
'Windows Forms',
10),

(19,
'Uma chave primária pode possuir valores repetidos dentro da mesma tabela.',
'Verdadeiro ou Falso',
'Intermediário',
'Banco de Dados',
10),

(20,
'Em C#, uma classe pode implementar mais de uma interface.',
'Verdadeiro ou Falso',
'Avançado',
'C#',
10);




INSERT INTO Alternativa
(Id, PerguntaId, Texto, Correta)
VALUES
(41, 11, 'Uma classe pode possuir implementação, enquanto uma interface define um contrato', true),
(42, 11, 'Uma interface sempre precisa possuir um construtor', false),
(43, 11, 'Uma classe não pode possuir métodos', false),
(44, 11, 'Uma interface só pode ser utilizada em bancos de dados', false);

INSERT INTO Alternativa
(Id, PerguntaId, Texto, Correta)
VALUES
(45, 12, 'HAVING', true),
(46, 12, 'WHERE', false),
(47, 12, 'ORDER BY', false),
(48, 12, 'FROM', false);

INSERT INTO Alternativa
(Id, PerguntaId, Texto, Correta)
VALUES
(49, 13, 'Relacionar uma tabela com outra por meio de uma referência', true),
(50, 13, 'Impedir qualquer SELECT na tabela', false),
(51, 13, 'Ordenar automaticamente os registros', false),
(52, 13, 'Substituir todas as chaves primárias', false);

INSERT INTO Alternativa
(Id, PerguntaId, Texto, Correta)
VALUES
(53, 14, 'Permitir que diferentes classes respondam de maneiras diferentes à mesma operação', true),
(54, 14, 'Impedir a criação de objetos', false),
(55, 14, 'Permitir somente métodos privados', false),
(56, 14, 'Eliminar a necessidade de classes', false);

INSERT INTO Alternativa
(Id, PerguntaId, Texto, Correta)
VALUES
(57, 15, 'git branch nome-da-branch', true),
(58, 15, 'git delete nome-da-branch', false),
(59, 15, 'git remove nome-da-branch', false),
(60, 15, 'git folder nome-da-branch', false);

INSERT INTO Alternativa
(Id, PerguntaId, Texto, Correta)
VALUES
(61, 16, 'A exceção pode encerrar a execução do programa', true),
(62, 16, 'A exceção é automaticamente corrigida pelo C#', false),
(63, 16, 'O programa sempre continua normalmente', false),
(64, 16, 'A exceção é transformada automaticamente em um aviso', false);

INSERT INTO Alternativa
(Id, PerguntaId, Texto, Correta)
VALUES
(65, 17, 'Pilha (Stack)', true),
(66, 17, 'Fila (Queue)', false),
(67, 17, 'Árvore', false),
(68, 17, 'Tabela Hash', false);

INSERT INTO Alternativa
(Id, PerguntaId, Texto, Correta)
VALUES
(69, 18, 'Executar uma ação quando o usuário clicar no botão', true),
(70, 18, 'Criar automaticamente uma tabela no banco', false),
(71, 18, 'Fechar obrigatoriamente o Windows', false),
(72, 18, 'Criar uma nova classe automaticamente', false);

INSERT INTO Alternativa
(Id, PerguntaId, Texto, Correta)
VALUES
(73, 19, 'Verdadeiro', false),
(74, 19, 'Falso', true);

INSERT INTO Alternativa
(Id, PerguntaId, Texto, Correta)
VALUES
(75, 20, 'Verdadeiro', true),
(76, 20, 'Falso', false);








