#version 330 core
in vec3 Normal0;
in vec2 TexCoord0;
in vec3 WorldPos0;

layout (location = 0) out vec3 WorldPosOut; 
layout (location = 1) out vec3 DiffuseOut; 
layout (location = 2) out vec3 NormalOut; 
layout (location = 3) out vec3 TexCoordOut; 

void main()
{
    WorldPosOut = WorldPos0; 
    DiffuseOut = vec3(.7,.45,.01); 
    NormalOut = normalize(Normal0); 
    TexCoordOut = vec3(TexCoord0, 0.0); 
}
