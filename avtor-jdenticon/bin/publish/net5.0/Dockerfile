#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# 运行环境
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
# 工作目录
WORKDIR /app
# copy
COPY . /app
# 卷映射
#VOLUME ["/adb_logs"]

# 暴露容器端口
EXPOSE 5100

# 指明环境运行
ENTRYPOINT ["dotnet", "avtor-jdenticon.dll", "--urls","http://*:5100"]