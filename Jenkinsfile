pipeline {
    agent any

    stages {
        stage('Desplegar') {
            steps {
                sh 'docker compose up -d --build'
            }
        }
    }
}
