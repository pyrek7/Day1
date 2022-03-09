pipeline {
    agent any
    environment{
     dotnet = '"C:\\Program Files\\dotnet\\dotnet.exe"'   
    }
    stages {
        stage('Build') {
            steps {
                echo "building.."
            }
        }
        stage('Run') {
            steps {
                echo "running.."
            }
        }
        stage('Clean') {
            steps {
                echo "cleaning.."
            }
        }
    }
}
