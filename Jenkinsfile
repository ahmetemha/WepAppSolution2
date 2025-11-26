pipeline {
    agent {
        docker { image 'node:24.11.1-alpine3.22' }
    }
    stages {
        stage('Test') {
            steps {
                sh 'node --eval "console.log(process.platform,process.env.CI)"'
            }
        }
    }
}