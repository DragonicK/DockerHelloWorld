node {
    stage('Checkout') {
        checkout scm
    }
    stage('Build') {
        bat 'dotnet build DockerHelloWorld.vbproj'
    }
}
