pipeline {

    agent any

    stages {
        stage("build"){

            steps {
                dotnet build
            }
        }

        stage("test"){

            steps {
                dotnet test
            }
        }

        stage("deploy"){

            steps {
                echo "deploy"
            }
        }
    }
}