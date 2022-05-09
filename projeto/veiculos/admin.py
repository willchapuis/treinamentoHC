from django.contrib import admin
from .models import *

admin.site.register(Categoria)
admin.site.register(Registro_Entrada)
admin.site.register(Registro_Saida)
admin.site.register(Fatura)