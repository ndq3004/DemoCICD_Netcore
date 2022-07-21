pipeline {

    agent any

    stages {
        stage("build"){

            steps {
                cd /var/lib/jenkins/workspace/PipelineNetcore1/
                sudo dotnet build
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