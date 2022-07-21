pipeline {

    agent any

    stages {
        stage("build"){

            steps {
                dotnet build -c Release
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