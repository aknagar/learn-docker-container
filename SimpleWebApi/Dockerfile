FROM microsoft/aspnet:4.7.1-windowsservercore-1709
ARG source
WORKDIR /inetpub/wwwroot
#$source is an environment variable that is defined before executing docker build.
# If $source is empty or absent, just use the default path obj/Docker/publish"
# COPY the path you find the in $source variable in to the current directory in the image (.)
COPY ${source:-obj/Docker/publish} .
