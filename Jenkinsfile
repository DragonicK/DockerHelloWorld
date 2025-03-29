pipeline {
	stage ('Checkout') {
		checkout scm
	}

	stage ('Build') {
		def directory = "C:\"

		echo "Publish ${configuration} -v ${version}"
		bat "\"${tool 'MSBuildPipeline'}\" DockerHelloWorld.vbproj /p:DeployOnBuild=true /p:PublishProfile=${configuration} /p:PublishDir=${directory}"
	 
	}
 
}