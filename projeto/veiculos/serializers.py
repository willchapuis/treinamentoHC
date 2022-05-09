from django.db import models
from rest_framework import serializers
from .models import *

class ControleVeiculosEntradaListViewSerializer(serializers.Serializer):
    id = serializers.IntegerField()
    placa = serializers.CharField()
    hora_entrada = serializers.DateTimeField()

    class Meta:
        model = Registro_Entrada
        field = [ 'id', 'placa', 'hora_entrada' ]

class ControleVeiculosEntradaViewSerializer(serializers.Serializer):
    placa = serializers.CharField()
    hora_entrada = serializers.DateTimeField()

    class Meta:
        model = Registro_Entrada
        field = [ 'placa', 'hora_entrada' ]
    
    def create(self, validated_data):
        return Registro_Entrada.objects.create(**validated_data)

class ControleVeiculosSaidaListViewSerializer(serializers.Serializer):
    id = serializers.IntegerField()
    placa = serializers.CharField()
    hora_saida = serializers.DateTimeField()

    class Meta:
        model = Registro_Saida
        field = [ 'id', 'placa', 'hora_saida' ]

class ControleVeiculosSaidaViewSerializer(serializers.Serializer):
    placa = serializers.CharField()
    hora_saida = serializers.DateTimeField()

    class Meta:
        model = Registro_Saida
        field = [ 'placa', 'hora_saida' ]
    
    def create(self, validated_data):
        return Registro_Saida.objects.create(**validated_data)

class ControleVeiculosFaturaListViewSerializer(serializers.Serializer):
    id = serializers.IntegerField()
    placa = serializers.CharField(source='entrada.placa')
    valor = serializers.CharField(source='calculaValor')

    # class Meta:
    #     model = Fatura
    #     field = [ 'id' ]
    
    def create(self, validated_data):
        return Fatura.objects.create(**validated_data)

class ControleVeiculosFaturaViewSerializer(serializers.Serializer):
    # id = serializers.IntegerField()
    categoria = serializers.PrimaryKeyRelatedField(queryset=Categoria.objects.all())
    entrada = serializers.PrimaryKeyRelatedField(queryset=Registro_Entrada.objects.all())
    saida = serializers.PrimaryKeyRelatedField(queryset=Registro_Saida.objects.all())
    placa = serializers.CharField(source='entrada.placa', required=False)
    valor = serializers.CharField(source='calculaValor', required=False)

    class Meta:
        model = Fatura
        field = [ 'id', 'categoria', 'entrada', 'saida', 'placa', 'valor' ]
    
    def create(self, validated_data):
        return Fatura.objects.create(**validated_data)

# class ControleVeiculosFaturaViewSerializer(serializers.Serializer):
#     entrada = serializers.CharField(source='entrada')
#     saida = serializers.CharField(source='saida')
#     placa = entrada.placa
#     valor = serializers.CharField(source='calculaValor')

#     class Meta:
#         model = Fatura
#         field = [ 'categoria', 'entrada', 'saida' ]
    
#     def create(self, validated_data):
#         return Fatura.objects.create(**validated_data)

class ControleVeiculosCategoriaListViewSerializer(serializers.Serializer):
    id = serializers.IntegerField()
    nome = serializers.CharField()
    valor_hora = serializers.DecimalField(max_digits=7, decimal_places=2)

    class Meta:
        model = Categoria
        field = [ 'id', 'nome', 'valor_hora' ]

    def create(self, validated_data):
        return Fatura.objects.create(**validated_data)