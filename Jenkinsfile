pipeline {
	stage ('Checkout') {
		checkout scm
	}

	stage ('Build') {
	    echo "Starting build process..."
		bat 'dotnet build DockerHelloWorld.vbproj'
	}
 
}