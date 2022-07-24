@Library('shared-library') _

    // Defining a dictionary with paths as keys and parameters as values to run dotnet build command
    def dotnetBuildParams = [
		"DemoCICDSolution/DemoCICDSolution.csproj": "/p:configuration=Release"
    ]

	
	// Defining a dictionary with paths as keys and parameters as values to run dotnet test command 	
	def dotnetTestParams = [
	    "/DemoUnitTestPipeline/DemoUnitTestPipeline.csproj": "--configuration Release"
	]

    def dockerDeployParams = []


pipeline {

    agent { node { label 'jenkins-slave'} }

    stages {
        stage("build"){
	    
            steps {
                dotnet("build",dotnetBuildParams)
            }
        }

        stage("test"){

            steps {
                //dotnet("test",dotnetTestParams) 
		    echo "test"
            }
        }

        stage("deploy"){
		agent { node { label 'jenkins-slave'} }
            steps {
		    echo "start deploy"
		    sh "ls"
                	sh label: '', script: '''cd /home/ec2-user/workspace/PipelineNetcore1/DemoCICDSolution
					ls
					sudo docker rmi imagetest
					sudo docker build -t imagetest .
					sudo docker container run -itd --name webserver -p 8080 imagetest'''
            }
        }
    }
}
