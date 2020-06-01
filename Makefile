# TODO: implement production deployment in container behind nginx

.PHONY: deploy
deploy: clean publish
	docker build -t blazorapp -f ci/Dockerfile .
	docker run --name blazorapp -p 8080:80 blazorapp:latest

.PHONY: publish
publish:
	dotnet publish -c Release

.PHONY: clean
clean: 
	docker rm -f blazorapp; echo 'Clean completed...'