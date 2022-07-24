@Library('shared-library') _

    // Defining a dictionary with paths as keys and parameters as values to run dotnet build command
    def dotnetBuildParams = [
		"DemoCICDSolution/DemoCICDSolution.csproj": "/p:configuration=Release"
    ]

	
	// Defining a dictionary with paths as keys and parameters as values to run dotnet test command 	
	def dotnetTestParams = [
	    "/DemoUnitTestPipeline/DemoUnitTestPipeline.csproj": "--configuration Release"
	]


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
                dotnet("test",dotnetTestParams) 
            }
        }

        stage("deploy"){

            steps {
                dir("DemoCICDSolution"){
                    sh "docker build -t aspnetapp ."
                    sh "docker run -d -p 8080:80 --name myapp aspnetapp"
                }
            }
        }
    }
}