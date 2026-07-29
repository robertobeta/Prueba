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

        stage('Desplegar') {
            steps {
                sh 'docker compose up -d --build'
            }
        }
    }
}
