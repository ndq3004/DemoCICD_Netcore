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
                dotnet("test",dotnetTestParams) 
            }
        }

        stage("deploy"){

            steps {
//                 sh label: '', script: '''rm -rf dockerimg
// 					mkdir dockerimg
// 					cd dockerimg
// 					cp /var/lib/jenkins/workspace/JenkinsfileJob/gameoflife-web/target/gameoflife.war .
// 					touch dockerfile
// 					cat <<EOT>>dockerfile
// 					FROM tomcat
// 					ADD gameoflife.war /usr/local/tomcat/webapps/
// 					CMD ["catalina.sh", "run"]
// 					EXPOSE 8080
// 					EOT
// 					sudo docker build -t webimage:$BUILD_NUMBER .
// 					sudo docker container run -itd --name webserver$BUILD_NUMBER -p 8080 webimage:$BUILD_NUMBER'''
            }
        }
    }
}
