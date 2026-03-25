# 🚀 Guia Rápido de Git e GitHub - Bootcamp Avanade

### 🛠️ Configuração Inicial
* **git config --global user.name**: Define o nome de exibição que aparecerá em todos os seus registros de código.
  * `git config --global user.name "Seu Nome"`
* **git config --global user.email**: Vincula o seu e-mail do GitHub aos seus arquivos para gerar o seu histórico.
  * `git config --global user.email "seu-email@exemplo.com"`
* **git config --list**: Exibe uma lista de todas as configurações atuais do Git para conferir os dados.
  * `git config --list`

---

### 📂 Gestão de Repositório
* **git init**: Cria um repositório novo do Git na pasta atual para começar a monitorar seus arquivos.
  * `git init`
* **git clone**: Baixa uma cópia completa de um projeto que já existe no GitHub para o seu computador.
  * `git clone https://github.com/usuario/projeto.git`

---

### 🔄 Ciclo de Trabalho Diário
* **git status**: Mostra o estado atual das suas alterações (o que foi modificado ou ainda não foi salvo).
  * `git status`
* **git add**: Seleciona as alterações que você fez e as prepara para o próximo salvamento.
  * `git add .`
* **git commit**: Salva permanentemente as alterações selecionadas no seu histórico local com uma mensagem.
  * `git commit -m "Explicação da alteração"`
* **git push**: Envia todas as alterações que você salvou no seu PC para o servidor do GitHub.
  * `git push origin main`
* **git pull**: Puxa e atualiza o seu código local com as novidades que estão no servidor do GitHub.
  * `git pull origin main`
