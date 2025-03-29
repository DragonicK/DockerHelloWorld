pipeline {
	stage ('Checkout') {
		checkout scm
	}

	stage ('Build') {
        // Diretório de publicação
        def publishDir = "C:/publish_output"

        // Configuração de build e versão (pode vir de variáveis no Jenkins ou configuração padrão)
        def configuration = "Release"
        def version = "1.0.0"

        // Exibindo informações
        echo "Building project with configuration: ${configuration}"
        echo "Publishing to: ${publishDir}"

         // Restaurar pacotes e construir o projeto usando dotnet CLI
         bat """
         ${env.DOTNET_SDK_HOME}/dotnet restore
         ${env.DOTNET_SDK_HOME}/dotnet build DockerHelloWorld.vbproj --configuration ${configuration} /p:Version=${version}
         ${env.DOTNET_SDK_HOME}/dotnet publish DockerHelloWorld.vbproj --configuration ${configuration} --output ${publishDir}
         """
	}
 
}