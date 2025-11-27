pipeline {
    agent {
        label 'yourDockerAgentLabel'
    }
    environment {
        SOME_ENV_VAR = 'some_value'
    }
    tools {
        docker 'latest'
    }
    stages {
        stage('first stage') {
		 steps {
          echo "docker build ."
		  }
       }
    }
 }