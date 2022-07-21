pipeline {

    agent any

    stages {
        stage("build"){

            steps {
                echo "build"
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