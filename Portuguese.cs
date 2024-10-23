﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitono
{
    public static class Portuguese
    {
        public static Dictionary<string, string> portuguese = new Dictionary<string, string>() {
            {"if", "se"},
            {"elif", "elif"},
            {"else", "outro"},
            {"print", "imprimir"},
            {"float", "flutuador"},
            {"input", "entrada"},
            {"str", "str"},
            {"string", "corda"},
            {"def", "definição"},
            {"assert", "afirmar"},
            {"exit", "saída"},
            {"close", "fechar"},
            {"quit", "desistir"},
            {"return", "retornar"},
            {"for", "para"},
            {"in", "em"},
            {"range", "faixa"},
            {"len", "lento"},
            {"import", "importar"},
            {"raise", "elevação"},
            {"module", "módulo"},
            {"aclose", "perto"},
            {"True", "Verdadeiro"},
            {"False", "Falso"},
            {"true", "verdadeiro"},
            {"false", "falso"},
            {"while", "enquanto"},
            {"not", "não"},
            {"and", "e"},
            {"del", "del"},
            {"fdel", "Fdel"},
            {"or", "ou"},
            {"get", "pegar"},
            {"fget", "fget"},
            {"break", "quebrar"},
            {"__init__", "__iniciar__"},
            {"__init_subclass__", "__init_subclass__"},
            {"from", "de"},
            {"as", "como"},
            {"removesuffix", "remove_sufixo"},
            {"suffix", "sufixo"},
            {"removeprefix", "removerprefixo"},
            {"prefix", "prefixo"},
            {"remove", "remover"},
            {"title", "título"},
            {"upper", "superior"},
            {"lower", "mais_baixo"},
            {"append", "acrescentar"},
            {"clear", "claro"},
            {"pop", "pop"},
            {"popitem", "item_pop"},
            {"shift", "mudança"},
            {"lshift", "turno"},
            {"__lshift__", "__lshift__"},
            {"__rlshift__", "__rlshift__"},
            {"__ilshift__", "__ilshift__"},
            {"rshift", "rshift"},
            {"__rshift__", "__rshift__"},
            {"__rrshift__", "__rrshift__"},
            {"__irshift__", "__irshift__"},
            {"unshift", "mudar_de_marcha"},
            {"insert", "inserir"},
            {"slice", "fatiar"},
            {"rstrip", "direito_tira"},
            {"lstrip", "esquerdo_tira"},
            {"strip", "tira"},
            {"self", "auto"},
            {"this", "esse"},
            {"list", "lista"},
            {"lists", "listas"},
            {"sorted", "classificado"},
            {"sort", "organizar"},
            {"reverse", "reverter"},
            {"__invert__", "__invertido__"},
            {"min", "min"},
            {"max", "máx."},
            {"sum", "soma"},
            {"key", "chave"},
            {"keys", "chaves"},
            {"only_keys", "somente_chaves"},
            {"fromkeys", "das_chaves"},
            {"fromlines", "das_linhas"},
            {"__name__", "__nome__"},
            {"__qualname__", "__qualnome__"},
            {"__module__", "__módulo__"},
            {"__defaults__", "__padrões__"},
            {"defaults", "padrões"},
            {"__code__", "__código__"},
            {"code", "código"},
            {"__kwdefaults__", "__kwdefaults__"},
            {"type", "tipo"},
            {"__type_params__", "__type_params__"},
            {"__self__", "__auto__"},
            {"__func__", "__func__"},
            {"__next__", "__próximo__"},
            {"__anext__", "__anexar__"},
            {"__new__", "__novo__"},
            {"__call__", "__chamar__"},
            {"__import__", "__importar__"},
            {"__file__", "__arquivo__"},
            {"__bases__", "__bases__"},
            {"__bytes__", "__bytes__"},
            {"bases", "bases"},
            {"__mro__", "__mro__"},
            {"mro", "mro"},
            {"__subclasses__", "__subclasses__"},
            {"__subclass__", "__subclasse__"},
            {"subclass", "subclasse"},
            {"subclasses", "subclasses"},
            {"line", "linha"},
            {"cache", "esconderijo"},
            {"no_cache", "sem_cache"},
            {"clear_cache", "limpar_cache"},
            {"make_file", "criar_arquivo"},
            {"make_table", "criar_tabela"},
            {"fobj", "fobj"},
            {"file", "arquivo"},
            {"File", "Arquivo"},
            {"__getattr__", "__getattr__"},
            {"__get__", "__obter__"},
            {"__getitem__", "__obteritem__"},
            {"__getitems__", "__obteritens__"},
            {"__delitem__", "__excluiritem__"},
            {"__delitems__", "__excluiritens__"},
            {"__setitem__", "__setitem__"},
            {"__set__", "__definir__"},
            {"__set_name_", "__conjunto_nome_"},
            {"__setitems__", "__setitems__"},
            {"__getattribute__", "__getattribute__"},
            {"getattribute", "obter_atributo"},
            {"getattr", "getattr"},
            {"get_close_matches", "get_close_matches"},
            {"get_matching_blocks", "get_matching_blocks"},
            {"__setattr__", "__setattr__"},
            {"setattr", "definir"},
            {"complex", "complexo"},
            {"__complex__", "__complexo__"},
            {"conjugate", "conjugado"},
            {"abs", "abdômen"},
            {"__abs__", "__abs__"},
            {"divmod", "divmod"},
            {"__divmod__", "__divmod__"},
            {"__rdivmod__", "__rdivmod__"},
            {"enumerate", "enumerar"},
            {"enum", "enumeração"},
            {"IntEnum", "IntEnum"},
            {"_constants", "_constantes"},
            {"constants", "constantes"},
            {"constant", "constante"},
            {"_NamedIntConstant", "_NamedIntConstant"},
            {"named", "nomeado"},
            {"aiter", "aiter"},
            {"__aiter__", "__aiter__"},
            {"aenter", "entrar"},
            {"__aenter__", "__aenter__"},
            {"iterator", "iterador"},
            {"Iterator", "Iterador"},
            {"iterators", "iteradores"},
            {"all", "todos"},
            {"any", "qualquer"},
            {"bin", "caixa"},
            {"bool", "bool"},
            {"__bool__", "__bool__"},
            {"breakpoint", "ponto_de_interrupção"},
            {"bytearray", "bytearray"},
            {"bytes", "bytes"},
            {"byte", "byte"},
            {"callable", "chamável"},
            {"pow", "prisioneiro_de_guerra"},
            {"__pow__", "__prisioneiro_de_guerra__"},
            {"__rpow__", "__rpow__"},
            {"__ipow__", "__ipow__"},
            {"chr", "cr"},
            {"char", "personagem"},
            {"charset", "conjunto_de_caracteres"},
            {"chars", "caracteres"},
            {"function", "função"},
            {"search_function", "função_pesquisa"},
            {"desinscribir", "descrever"},
            {"EncodedFile", "Arquivo_Codificado"},
            {"classmethod", "método_de_classe"},
            {"compile", "compilar"},
            {"delattr", "delattr"},
            {"__delattr__", "__delattr__"},
            {"__delete__", "__excluir__"},
            {"__objclass__", "__objclass__"},
            {"dir", "dir"},
            {"directory", "diretório"},
            {"eval", "avaliação"},
            {"exec", "executivo"},
            {"event", "evento"},
            {"filter", "filtro"},
            {"format", "formatar"},
            {"vformat", "formato_v"},
            {"__format__", "__formatar__"},
            {"hasattr", "hasattr"},
            {"__hasattr__", "__hasattr__"},
            {"hash", "hash"},
            {"__hash__", "__hash__"},
            {"hashable", "hashável"},
            {"Hashable", "Hashável"},
            {"help", "ajuda"},
            {"hex", "hexadecimal"},
            {"id", "eu_ia"},
            {"instance", "exemplo"},
            {"instances", "instâncias"},
            {"isinstance", "isinstance"},
            {"__instancecheck__", "__instancecheck__"},
            {"__subclasscheck__", "__subclasscheck__"},
            {"issubclass", "ésubclasse"},
            {"issubset", "ésubconjunto"},
            {"subset", "subconjunto"},
            {"iter", "iterar"},
            {"locals", "moradores_locais"},
            {"local", "local"},
            {"map", "mapa"},
            {"next", "próximo"},
            {"object", "objeto"},
            {"obj", "obj"},
            {"objects", "objetos"},
            {"oct", "outubro"},
            {"open", "abrir"},
            {"ord", "ord"},
            {"unicode", "Unicode"},
            {"unicodedata", "dados_unicode"},
            {"property", "propriedade"},
            {"__slots__", "__slots__"},
            {"__weakref__", "__fracoref__"},
            {"weakref", "referência_fraca"},
            {"getter", "pegador"},
            {"setter", "levantador"},
            {"deleter", "deletar"},
            {"repr", "representação"},
            {"__repr__", "__repr__"},
            {"reversed", "invertido"},
            {"round", "redondo"},
            {"__round__", "__redondo__"},
            {"trunc", "truncar"},
            {"__trunc__", "__trunc__"},
            {"__floor__", "__chão__"},
            {"floor", "chão"},
            {"__ceil__", "__teto__"},
            {"ceil", "teto"},
            {"start", "começar"},
            {"stop", "parar"},
            {"reset", "reiniciar"},
            {"getstate", "obter_estado"},
            {"setstate", "definir_estado"},
            {"step", "etapa"},
            {"static", "estático"},
            {"staticmethod", "método_estático"},
            {"method", "método"},
            {"errors", "erros"},
            {"error", "erro"},
            {"error_handler", "manipulador_de_erros"},
            {"idna", "idna"},
            {"encoding", "codificação"},
            {"encodings", "codificações"},
            {"data_encoding", "codificação_de_dados"},
            {"file_encoding", "codificação_de_arquivo"},
            {"encode", "codificar"},
            {"encoder", "codificador"},
            {"incrementalencoder", "codificador_incremental"},
            {"IncrementalEncoder", "Codificador_Incremental"},
            {"getencoder", "getencoder"},
            {"getincrementalencoder", "obter_codificador_incremental"},
            {"decoding", "decodificação"},
            {"decode", "decodificar"},
            {"decoder", "decodificador"},
            {"incrementaldecoder", "decodificador_incremental"},
            {"IncrementalDecoder", "Decodificador_Incremental"},
            {"getdecoder", "getdecodificador"},
            {"getincrementaldecoder", "obter_decodificador_incremental"},
            {"iterable", "iterável"},
            {"Iterable", "Iterável"},
            {"async_iterable", "assíncrono_iterável"},
            {"AsyncIterable", "AsyncIterável"},
            {"iterables", "iteráveis"},
            {"async_iterables", "async_iterables"},
            {"async_iterator", "async_iterador"},
            {"AsyncIterator", "AsyncIterator"},
            {"async_iterators", "async_iterators"},
            {"async_generator", "async_generator"},
            {"async_generators", "geradores_assíncronos"},
            {"AsyncGenerator", "Gerador_assíncrono"},
            {"object_or_type", "objeto_ou_tipo"},
            {"super", "super"},
            {"tuple", "tupla"},
            {"kwds", "kwds"},
            {"kwd", "kwd"},
            {"kws", "obrigado"},
            {"kw", "kw"},
            {"kwarg", "kwarg"},
            {"kwargs", "kwargs"},
            {"arg", "argumento"},
            {"args", "argumentos"},
            {"__args__", "__args__"},
            {"vars", "vars"},
            {"strict", "estrito"},
            {"zip", "zip"},
            {"fromlist", "da_lista"},
            {"level", "nível"},
            {"source", "fonte"},
            {"filename", "nome_do_arquivo"},
            {"mode", "modo"},
            {"abiflags", "abiflags"},
            {"addaudithook", "adicionarauditook"},
            {"hook", "gancho"},
            {"argv", "argumentov"},
            {"audit", "auditoria"},
            {"base_exec_prefix", "base_exec_prefixo"},
            {"base_prefix", "prefixo_base"},
            {"builtin_module_names", "nomes_módulos_construídos"},
            {"call_tracing", "rastreamento_de_chamada"},
            {"_clear_type_cache", "_clear_type_cache"},
            {"_current_frames", "_quadros_atual"},
            {"_current_exceptions", "_atual_exceções"},
            {"breakpointhook", "gancho_de_ponto_de_interrupção"},
            {"flags", "bandeiras"},
            {"flag", "bandeira"},
            {"IntFlag", "IntFlag"},
            {"dont_inherit", "não_herdar"},
            {"inherit", "herdar"},
            {"optimize", "otimizar"},
            {"textwrap", "quebra_de_texto"},
            {"wrap", "enrolar"},
            {"text", "texto"},
            {"number", "número"},
            {"word", "palavra"},
            {"possibilities", "possibilidades"},
            {"cutoff", "cortar"},
            {"ndiff", "nãodiferença"},
            {"imag", "imagem"},
            {"complexvalue", "valor_complexo"},
            {"floatvalue", "valor_flutuante"},
            {"sign", "sinal"},
            {"absfloatvalue", "valorabsfloat"},
            {"__float__", "__flutuador__"},
            {"__int__", "__int__"},
            {"__index__", "__índice__"},
            {"index", "índice"},
            {"lastindex", "último_índice"},
            {"lastgroup", "último_grupo"},
            {"indices", "índices"},
            {"mapping", "mapeamento"},
            {"mappingproxy", "proxy_de_mapeamento"},
            {"__dir__", "__dir__"},
            {"expression", "expressão"},
            {"infinity", "infinidade"},
            {"nan", "nan"},
            {"digit", "dígito"},
            {"digits", "dígitos"},
            {"digitpart", "parte_do_dígito"},
            {"exponent", "expoente"},
            {"exp", "experiência"},
            {"format_spec", "formato_especificação"},
            {"default", "padrão"},
            {"setdefault", "definir_padrão"},
            {"prompt", "incitar"},
            {"base", "base"},
            {"classinfo", "informações_de_classe"},
            {"sentinel", "sentinela"},
            {"arg1", "arg1"},
            {"arg2", "arg2"},
            {"arg3", "arg3"},
            {"arg4", "arg4"},
            {"arg5", "arg5"},
            {"offset", "desvio"},
            {"unpack", "desempacotar"},
            {"unpack_from", "descompactar_de"},
            {"iter_unpack", "iter_unpack"},
            {"calcsize", "calcular_tamanho"},
            {"codec", "codec"},
            {"codecs", "codecs"},
            {"CodecInfo", "CodecInfo"},
            {"write", "escrever"},
            {"writelines", "linhas_de_escrita"},
            {"read", "ler"},
            {"stream", "fluxo"},
            {"streamreader", "leitor_de_fluxo"},
            {"StreamReader", "StreamReader"},
            {"Reader", "Leitor"},
            {"Writer", "Escritor"},
            {"StreamRecoder", "StreamRecoder"},
            {"StreamReaderWriter", "StreamReaderWriter"},
            {"getreader", "getreader"},
            {"streamwriter", "escritor_de_stream"},
            {"StreamWriter", "StreamWriter"},
            {"getwriter", "escritor"},
            {"newline", "nova_linha"},
            {"closefd", "fechado"},
            {"write_through", "escrever_através"},
            {"opener", "abridor"},
            {"modulo", "emmódulo"},
            {"modulus", "modulus"},
            {"mod", "moda"},
            {"inv_base", "base_inv"},
            {"sep", "setembro"},
            {"bytes_per_sep", "bytes_per_sep"},
            {"seperate", "separar"},
            {"end", "fim"},
            {"ends", "termina"},
            {"flush", "liberar"},
            {"seq", "seq"},
            {"which", "qual"},
            {"sequence", "sequência"},
            {"Sequence", "Sequência"},
            {"SequenceMatcher", "SequenceMatcher"},
            {"Differ", "Diferente"},
            {"HtmlDiff", "HtmlDiff"},
            {"wrapcolumn", "coluna_envolvente"},
            {"linejunk", "lixo_de_linha"},
            {"isjunk", "é_lixo"},
            {"autojunk", "lixo_automático"},
            {"set_seqs", "set_seqs"},
            {"set_seq1", "set_seq1"},
            {"set_seq2", "set_seq2"},
            {"find_longest_match", "find_longest_match"},
            {"alo", "alo"},
            {"ahi", "ai"},
            {"blo", "blo"},
            {"bhi", "bhi"},
            {"charjunk", "charjunk"},
            {"IS_CHARACTER_JUNK", "IS_CHARACTER_JUNK"},
            {"MutableSequence", "Sequência_mutável"},
            {"ndigits", "ndígitos"},
            {"ndigit", "ndígito"},
            {"restore", "restaurar"},
            {"bit_length", "comprimento_bit"},
            {"bit_count", "contagem_bits"},
            {"new_itemsize", "tamanho_novo_item"},
            {"itemsize", "tamanho_do_item"},
            {"count", "contar"},
            {"to_bytes", "to_bytes"},
            {"tobytes", "tobytes"},
            {"from_bytes", "de_bytes"},
            {"length", "comprimento"},
            {"byte_length", "comprimento_byte"},
            {"byteorder", "ordem_de_bytes"},
            {"order", "ordem"},
            {"signed", "assinado"},
            {"as_integer_ratio", "as_integer_ratio"},
            {"is_integer", "é_inteiro"},
            {"fromhex", "de_hexadecimal"},
            {"fraction", "fração"},
            {"fractions", "frações"},
            {"hash_fraction", "hash_fração"},
            {"hash_float", "hash_float"},
            {"hash_complex", "hash_complex"},
            {"hash_value", "valor_hash"},
            {"__iter__", "__iter__"},
            {"join", "juntar"},
            {"copy", "cópia"},
            {"copyright", "direitos_autorais"},
            {"credits", "créditos"},
            {"license", "licença"},
            {"extend", "estender"},
            {"capitalize", "capitalizar"},
            {"casefold", "pasta"},
            {"doblar", "dobrar"},
            {"center", "centro"},
            {"sys", "sistema"},
            {"_debugmallocstats", "_debugmallocstats"},
            {"dllhandle", "dllhandle"},
            {"displayhook", "gancho_de_exibição"},
            {"dont_write_bytecode", "não_write_bytecode"},
            {"_emscripten_info", "_emscripten_info"},
            {"emscripten_version", "versão_escrita"},
            {"runtime", "tempo_de_execução"},
            {"pthreads", "threads"},
            {"shared_memory", "memória_compartilhada"},
            {"pycache_prefix", "pycache_prefix"},
            {"excepthook", "exceto_gancho"},
            {"__breakpointhook__", "__breakpointhook__"},
            {"__displayhook__", "__displayhook__"},
            {"__excepthook__", "__exceto_gancho__"},
            {"__unraisablehook__", "__unraisablehook__"},
            {"exc_info", "exc_info"},
            {"exec_prefix", "prefix_exec"},
            {"executable", "executável"},
            {"inspect", "inspecionar"},
            {"interactive", "interativo"},
            {"isolated", "isolado"},
            {"no_user_site", "no_user_site"},
            {"no_site", "nenhum_site"},
            {"ignore_environment", "ignorar_ambiente"},
            {"bytes_warning", "bytes_warning"},
            {"quiet", "quieto"},
            {"hash_randomization", "hash_randomização"},
            {"dev_mode", "dev_mode"},
            {"utf8_mode", "utf8_mode"},
            {"safe_path", "caminho_seguro"},
            {"warn_default_encoding", "warning_default_encoding"},
            {"float_info", "float_info"},
            {"epsilon", "épsilon"},
            {"dig", "escavação"},
            {"mant_dig", "mant_dig"},
            {"max_exp", "max_exp"},
            {"max_10_exp", "máx_10_exp"},
            {"min_exp", "min_exp"},
            {"min_10_exp", "min_10_exp"},
            {"radix", "raiz"},
            {"rounds", "rodadas"},
            {"float_repr_style", "float_repr_style"},
            {"getallocatedblocks", "obter_blocos_alocados"},
            {"getunicodeinternedsize", "getunicodeinternedsize"},
            {"getandroidapilevel", "obterandroidapilevel"},
            {"getdefaultencoding", "getdefaultencoding"},
            {"getdlopenflags", "getdlopenflags"},
            {"getfilesystemencoding", "codificação_do_sistema_de_arquivos"},
            {"getfilesystemencodeerrors", "getfilesystemencodeerrors"},
            {"get_int_max_str_digits", "get_int_max_str_digits"},
            {"getrefcount", "obterrefcount"},
            {"getrecursionlimit", "obter_limite_de_recursão"},
            {"getsizeof", "getsizeof"},
            {"getswitchinterval", "intervalo_de_comutação"},
            {"_getframe", "_getframe"},
            {"depth", "profundidade"},
            {"_getframemodulename", "_nome_do_módulo_getframe"},
            {"getprofile", "obter_perfil"},
            {"gettrace", "obter_rastreamento"},
            {"getwindowsversion", "obter_versão_do_Windows"},
            {"get_asyncgen_hooks", "get_asyncgen_hooks"},
            {"get_coroutine_origin_tracking_depth", "get_coroutine_origin_tracking_profundidade"},
            {"hash_info", "hash_info"},
            {"inf", "informações"},
            {"algorithm", "algoritmo"},
            {"hash_bits", "hash_bits"},
            {"seed_bits", "sementes_bits"},
            {"hexversion", "hexversão"},
            {"implementation", "implementação"},
            {"int_info", "int_info"},
            {"bits_per_digit", "bits_por_dígito"},
            {"sizeof_digit", "tamanhode_dígito"},
            {"default_max_str_digits", "default_max_str_digits"},
            {"str_digits_check_threshold", "str_digits_check_threshold"},
            {"__interactivehook__", "__interativohook__"},
            {"intern", "estagiário"},
            {"_is_gil_enabled", "_is_gil_enabled"},
            {"is_finalizing", "está_finalizando"},
            {"last_exc", "último_exc"},
            {"_is_interned", "_está_internado"},
            {"last_type", "último_tipo"},
            {"last_value", "último_valor"},
            {"last_traceback", "last_traceback"},
            {"maxsize", "tamanho_máximo"},
            {"maxunicode", "maxunicode"},
            {"meta_path", "meta_path"},
            {"modules", "módulos"},
            {"orig_argv", "origem_argv"},
            {"path_hooks", "caminho_hooks"},
            {"path_importer_cache", "caminho_importador_cache"},
            {"platform", "plataforma"},
            {"platlibdir", "platlibdir"},
            {"ps1", "ps1"},
            {"ps2", "ps2"},
            {"setdlopenflags", "setdlopenflags"},
            {"set_int_max_str_digits", "set_int_max_str_digits"},
            {"setprofile", "definir_perfil"},
            {"profilefunc", "função_de_perfil"},
            {"maxdigits", "máximo_de_dígitos"},
            {"setrecursionlimit", "definir_limite_de_recursão"},
            {"limit", "limite"},
            {"setswitchinterval", "setintervalo_de_comutação"},
            {"interval", "intervalo"},
            {"settrace", "definir_rastreamento"},
            {"tracefunc", "tracefunc"},
            {"set_asyncgen_hooks", "set_asyncgen_hooks"},
            {"firstiter", "primeira_edição"},
            {"finalizer", "finalizador"},
            {"set_coroutine_origin_tracking_depth", "set_coroutine_origin_tracking_profundidade"},
            {"activate_stack_trampoline", "ativar_stack_trampolim"},
            {"backend", "back_end"},
            {"deactivate_stack_trampoline", "desativar_stack_trampolim"},
            {"is_stack_trampoline_active", "is_stack_trampoline_active"},
            {"_enablelegacywindowsfsencoding", "_enablelegacywindowsfsencoding"},
            {"stdout", "saída_padrão"},
            {"stdin", "stdin"},
            {"stderr", "stderr"},
            {"__stdin__", "__stdin__"},
            {"__stderr__", "__stderr__"},
            {"__stdout__", "__stdout__"},
            {"stdlib_module_names", "stdlib_module_names"},
            {"thread_info", "thread_info"},
            {"lock", "trancar"},
            {"version", "versão"},
            {"tracebacklimit", "limite_de_rastreamento"},
            {"unraisablehook", "gancho_impossível_de_levantar"},
            {"unraisable", "inalcançável"},
            {"api_version", "versão_api"},
            {"version_info", "versão_info"},
            {"warnoptions", "opções_de_aviso"},
            {"winver", "vencedor"},
            {"monitoring", "monitoramento"},
            {"_xoptions", "_xopções"},
            {"asctime", "asctime"},
            {"pthread_getcpuclockid", "pthread_getcpuclockid"},
            {"thread_id", "thread_id"},
            {"clock_getres", "relógio_getres"},
            {"clk_id", "clk_id"},
            {"clock_gettime", "relógio_gettime"},
            {"clock_gettime_ns", "relógio_gettime_ns"},
            {"clock_settime", "hora_relógio"},
            {"clock_settime_ns", "relógio_settime_ns"},
            {"secs", "segundos"},
            {"get_clock_info", "get_clock_info"},
            {"gmtime", "horário_gm"},
            {"localtime", "hora_local"},
            {"mktime", "mktime"},
            {"monotonic", "monotônico"},
            {"monotonic_ns", "monotônico_ns"},
            {"perf_counter", "contador_perf"},
            {"perf_counter_ns", "perf_counter_ns"},
            {"process_time", "tempo_processo"},
            {"process_time_ns", "process_time_ns"},
            {"sleep", "dormir"},
            {"strftime", "horário_de_trabalho"},
            {"strptime", "tempo_de_strp"},
            {"struct_time", "struct_time"},
            {"tm_year", "tm_ano"},
            {"tm_mon", "tm_mon"},
            {"tm_mday", "tm_mday"},
            {"tm_hour", "tm_hora"},
            {"tm_min", "tm_min"},
            {"tm_sec", "tm_sec"},
            {"tm_wday", "tm_wday"},
            {"tm_yday", "tm_yday"},
            {"tm_isdst", "tm_isdst"},
            {"tm_zone", "zona_tm"},
            {"tm_gmtoff", "tm_gmtoff"},
            {"time_ns", "tempo_ns"},
            {"thread_time", "thread_time"},
            {"thread_time_ns", "thread_time_ns"},
            {"tzset", "tzset"},
            {"CLOCK_BOOTTIME", "CLOCK_BOOTTIME"},
            {"CLOCK_HIGHRES", "CLOCK_HIGHRES"},
            {"CLOCK_MONOTONIC", "CLOCK_MONOTONIC"},
            {"CLOCK_MONOTONIC_RAW", "CLOCK_MONOTONIC_RAW"},
            {"CLOCK_MONOTONIC_RAW_APPROX", "CLOCK_MONOTONIC_RAW_APPROX"},
            {"CLOCK_PROCESS_CPUTIME_ID", "CLOCK_PROCESS_CPUTIME_ID"},
            {"CLOCK_PROF", "CLOCK_PROF"},
            {"CLOCK_TAI", "CLOCK_TAI"},
            {"CLOCK_THREAD_CPUTIME_ID", "CLOCK_THREAD_CPUTIME_ID"},
            {"CLOCK_UPTIME", "CLOCK_UPTIME"},
            {"CLOCK_UPTIME_RAW", "CLOCK_UPTIME_RAW"},
            {"CLOCK_UPTIME_RAW_APPROX", "CLOCK_UPTIME_RAW_APPROX"},
            {"CLOCK_REALTIME", "CLOCK_REALTIME"},
            {"altzone", "zona_alta"},
            {"daylight", "luz_do_dia"},
            {"random", "aleatório"},
            {"seed", "semente"},
            {"randbytes", "bytes_aleatórios"},
            {"randrange", "Randrange"},
            {"randint", "inteiroaleatório"},
            {"getrandbits", "obterrandbits"},
            {"choice", "escolha"},
            {"choices", "escolhas"},
            {"population", "população"},
            {"weights", "pesos"},
            {"cum_weights", "pesos_porra"},
            {"shuffle", "embaralhar"},
            {"sample", "amostra"},
            {"counts", "conta"},
            {"binomialvariate", "variável_binomial"},
            {"uniform", "uniforme"},
            {"triangular", "triangular"},
            {"low", "baixo"},
            {"high", "alto"},
            {"betavariate", "variável_beta"},
            {"alpha", "alfa"},
            {"beta", "beta"},
            {"expovariate", "expovariável"},
            {"lambd", "lambda"},
            {"gammavariate", "variável_gama"},
            {"gauss", "Gauss"},
            {"sigma", "sigma"},
            {"mu", "mu"},
            {"lognormvariate", "lognormvariável"},
            {"normalvariate", "normalvariado"},
            {"vonmisesvariate", "vonmisesvariate"},
            {"kappa", "capa"},
            {"paretovariate", "paretovariado"},
            {"weibullvariate", "weibullvariate"},
            {"Random", "Aleatório"},
            {"SystemRandom", "SistemaRandom"},
            {"ArithmeticError", "Erro_Aritmético"},
            {"AssertionError", "Erro_de_afirmação"},
            {"AttributeError", "AtributoError"},
            {"Exception", "Exceção"},
            {"EOFError", "EOFError"},
            {"FloatingPointError", "Erro_de_ponto_flutuante"},
            {"GeneratorExit", "Gerador_Sair"},
            {"IllegalMonthError", "Erro_Mês_Ilegal"},
            {"IllegalWeekdayError", "Erro_ilegal_de_dia_da_semana"},
            {"ImportError", "Erro_de_importação"},
            {"IndentationError", "Erro_de_recuo"},
            {"IndexError", "Erro_de_índice"},
            {"InvalidTZPathWarning", "Aviso_de_TZPath_inválido"},
            {"KeyError", "KeyError"},
            {"KeyboardInterrupt", "TecladoInterrupção"},
            {"LookupError", "Erro_de_pesquisa"},
            {"MemoryError", "Erro_de_memória"},
            {"NameError", "NomeErro"},
            {"NotImplementedError", "Erro_NotImplemented"},
            {"OSError", "Erro_de_sistema_operacional"},
            {"OverflowError", "Erro_de_estouro"},
            {"ReferenceError", "Erro_de_referência"},
            {"RuntimeError", "Erro_de_tempo_de_execução"},
            {"StopIteration", "PararIteração"},
            {"StopAsyncIteration", "StopAsyncIteration"},
            {"SyntaxError", "Erro_de_sintaxe"},
            {"TabError", "TabError"},
            {"SystemError", "Erro_do_sistema"},
            {"SystemExit", "Saída_do_sistema"},
            {"TypeError", "Erro_de_tipo"},
            {"UnboundLocalError", "UnboundLocalError"},
            {"UnicodeError", "Erro_Unicode"},
            {"UnicodeEncodeError", "UnicodeEncodeError"},
            {"UnicodeDecodeError", "UnicodeDecodeError"},
            {"UnicodeTranslateError", "UnicodeTranslateError"},
            {"ValueError", "Erro_de_valor"},
            {"ZeroDivisionError", "Erro_ZeroDivision"},
            {"ZoneInfoNotFoundError", "ZoneInfoNotFoundError"},
        };
    }
}