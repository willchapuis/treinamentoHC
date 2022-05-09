from django.forms import ModelForm
from .models import *

class RegistroEntradaForm(ModelForm):
    class Meta:
        model = Registro_Entrada
        fields = ['placa', 'hora_entrada']

class RegistroSaidaForm(ModelForm):
    class Meta:
        model = Registro_Saida
        fields = ['placa', 'hora_saida']