@Library('shared-library') _

    // Defining a dictionary with paths as keys and parameters as values to run dotnet build command
    def dotnetBuildParams = [
		"DemoCICDSolution/DemoCICDSolution.csproj": "-c Release -o site"
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
                dotnet("publish",dotnetBuildParams)
            }
        }

        stage("test"){

            steps {
                dotnet("test",dotnetTestParams) 
            }
        }

        stage("deploy"){

            steps {
                echo "deploy"
            }
        }
    }
}