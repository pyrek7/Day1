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
         stage('Script') {
            steps {
                script{
                    def hello = "hello world";
                    println hello;
                    for(x in 1..5)
                        println x
                }
            }
        }
        stage('docker') {
            steps {
                bat "docker build ."
            }
        }
    }
}
