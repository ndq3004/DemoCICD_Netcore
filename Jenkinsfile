pipeline {

    agent any

    stages {
        stage("build"){

            steps {
                echo $(pwd)
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