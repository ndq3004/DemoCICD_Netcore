@Library('shared-library') _

    // Defining a dictionary with paths as keys and parameters as values to run dotnet build command
    def dotnetBuildParams = [
		"\\DemoCICDSolution\\DemoCICDSolution.csproj": "/p:configuration=Release"
		]
	
    // Defining a dictionary with paths as keys and parameters as values to run dotnet publish command
    def dotnetPublishParams = [
		"\\DemoCICDSolution\\DemoCICDSolution.csproj": "/p:configuration=Release /p:PublishProfile=FolderProfile -o ..\\..\\Publish\\Project3\\dotnetProject3
		]
	
	// Defining a dictionary with paths as keys and parameters as values to run dotnet test command 	
	def dotnetTestParams = [
	    "\\DemoUnitTestPipeline\\DemoUnitTestPipeline.csproj": "--configuration Release"
	]


pipeline {

    agent any

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
                echo "deploy"
            }
        }
    }
}