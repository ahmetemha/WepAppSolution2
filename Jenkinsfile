pipeline {
    agent {
        label 'yourDockerAgentLabel'
    }
    environment {
        SOME_ENV_VAR = 'some_value'
    }
    tools {
        docker 'latest'
        jdk 'your_jdk_version'
    }
    stages {
        stage('first stage') {
          sh("docker build .")
       }
    }
 }