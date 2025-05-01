# SimuladorDePatos

**Alunos**: Alex Mendes, Wendell Leonardo e Yalle Ramos.

Respostas da Atividade
**2)** Principais ganhos desta estratégia:

- Flexibilidade em tempo de execução

- Posso trocar o comportamento de voo ou de som de um pato dinamicamente, sem alterar código-fonte das subclasses.

- Baixo acoplamento / Alta coesão

- Classe Duck não “conhece” detalhes de como cada comportamento é executado, apenas a interface.

- Reuso e fácil extensão

- Novas formas de voar ou de “quack” são adicionadas criando novas classes de estratégia, sem mexer nas classes de pato.

**3)** Uma possível desvantagem desta estratégia é o aumento do número de classes, uma vez que ao se criar várias interfaces e implementações, o código pode acabar com uma baixa coesão, desta forma sendo necessário que haja uma organização do programa para facilitar o compreendimento.
