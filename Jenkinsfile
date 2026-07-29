pipeline {
    agent any

    stages {
        stage('Clonar código') {
            steps {
                git branch: 'master',
                    url: 'https://github.com/robertobeta/Prueba.git',
                    credentialsId: 'github-token'
            }
        }

        stage('Construir imagen') {
            steps {
                sh 'docker compose build'
            }
        }

        stage('Desplegar') {
            steps {
                sh 'docker compose down
'
                sh 'docker compose up -d'
            }
        }
    }
}
