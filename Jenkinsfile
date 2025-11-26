pipeline {
    agent {
        docker { image 'node:24.11.1-alpine3.22' }
    }
    stages {
        stage('Test') {
            steps {
               echo "ddsfsdfdsfdsf"
            }
        }
        stage('Test1') {
            steps {
                echo "jhfgjhghjhgjhgjghj"
            }
        }
        stage('Test2') {
            steps {
                sh 'node --eval "console.log(process.platform,process.env.CI)"'
            }
        }
    }
}