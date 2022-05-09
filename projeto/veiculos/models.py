from django.db import models
from decimal import Decimal

class Categoria(models.Model):
    nome = models.CharField(max_length=100)
    valor_hora = models.DecimalField(max_digits=7, decimal_places=2, default=0.0)

    def __str__(self):
        return self.nome

class Registro_Entrada(models.Model):
    placa = models.CharField(max_length=100)
    hora_entrada = models.DateTimeField()

    class Meta:
        verbose_name_plural = 'Registros de Entrada'
    
    def __str__(self):
        return self.placa

class Registro_Saida(models.Model):
    placa = models.CharField(max_length=100)
    hora_saida = models.DateTimeField()

    class Meta:
        verbose_name_plural = 'Registros de Saida'
    
    def __str__(self):
        return self.placa

class Fatura(models.Model):
    categoria = models.ForeignKey(Categoria, on_delete=models.CASCADE)
    entrada = models.ForeignKey(Registro_Entrada, on_delete=models.CASCADE)
    saida = models.ForeignKey(Registro_Saida, on_delete=models.CASCADE)
    observacoes = models.TextField(null=True, blank=True, default="")
    
    def __str__(self):
        return 'Placa: ' + str(self.entrada.placa) + '  -  Valor: ' + str((abs(self.saida.hora_saida - self.entrada.hora_entrada).total_seconds() / 3600.0) * float(self.categoria.valor_hora))
    
    def calculaValor(self):
        hora_inicio = self.entrada.hora_entrada
        hora_final = self.saida.hora_saida
        valor_hora = float(self.categoria.valor_hora)
        valor = (abs(hora_final - hora_inicio).total_seconds() / 3600.0) * valor_hora
        return str(valor)
    
    def getPlaca(self):
        return self.entrada.placa