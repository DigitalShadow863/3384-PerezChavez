# Control de versiones
### GitBash 
Git Bash es una aplicación que permite usar Git desde una línea de comandos en Windows. Proporciona un entorno similar a la terminal de Linux, donde se pueden ejecutar los comandos de Git (como git init, git clone, git add, git commit, git push) y administrar repositorios de forma sencilla.

### GitHub
GitHub es una plataforma en línea que permite almacenar, compartir y colaborar en proyectos que usan Git. Funciona como una nube para los repositorios, donde varios usuarios pueden trabajar en el mismo código, revisar cambios y contribuir desde cualquier lugar.

## Comandos

#### Comandos de Configuracion
- git config --global user.name "Tu Nombre"

- git config --global user.email "tu@email.com"

- git config --global core.editor "code -wait"

- git config --list

#### Comandos Básicos de Repositorio
- git init # Inicializar repositorio

- git status # Ver estado de archivos

- git add archivo.txt # Agregar archivo específico

- git add . # Agregar todos los archivos

- git commit -m "mensaje" # Crear commit con mensaje

- git log # Ver historial de commits

- git log --oneline # Ver historial resumido

#### Comandos de Repositorio Remoto
- git remote add origin [URL] # Conectar con repositorio remoto

- git remote -v # Ver repositorios remotos

- git push origin main # Subir cambios a GitHub

- git push -u origin main # Primer push (establecer upstream)

- git pull origin main # Descargar cambios de GitHub

- git clone [URL] # Clonar repositorio existente

#### Comandos de Información
- git diff # Ver cambios no confirmados

- git diff --staged # Ver cambios en staging

- git show # Ver último commit

- git branch # Ver ramas locales

- git branch -r # Ver ramas remotas