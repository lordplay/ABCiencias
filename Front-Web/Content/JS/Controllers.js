(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedorCadastroController', ['$scope', 'fornecedorService', 'SweetAlert', FornecedorCadastroController]);

    function FornecedorCadastroController($scope, fornecedorService, SweetAlert) {

        ObterServicos();
        $scope.checkedService = [];
        $scope.CadastrarFornecedor = CadastrarFornecedor;
        $scope.toggleService = function (servico) {
            if ($scope.checkedService.indexOf(servico) === -1) {
                $scope.checkedService.push(servico);
                console.log($scope.checkedService);
            } else {
                $scope.checkedService.splice($scope.checkedService.indexOf(servico), 1);
            }
        }

        function ObterServicos() {
            fornecedorService.ObterServicos().then(function (response) {
                $scope.servicos = response;
                console.log(response);
            });
        }

        function CadastrarFornecedor() {
            var cadastro = {};
            cadastro.razaosocial = $scope.razaosocial;
            cadastro.cnpj = $scope.cnpj;
            cadastro.descricao = $scope.descricao;
            cadastro.servicos = $scope.checkedService;
            console.log(cadastro);
            fornecedorService.CadastrarFornecedor(cadastro).then(function (response) {
                SweetAlert.swal("Ok", response, "success");
            })
        }

    }
})();


(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedoresInfoController', ['$scope', 'fornecedorService', '$stateParams', FornecedoresInfoController]);

    function FornecedoresInfoController($scope, fornecedorService, $stateParams) {

        if ($stateParams.Id) {
            ObterInformacoesFornecedor($stateParams.Id);
        }

        function ObterInformacoesFornecedor(id) {
            fornecedorService.ObterInformacoesFornecedor(id).then(function (response) {
                $scope.fornecedor = response;
            })
        }
    }
})();


(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedoresListagemController', ['$scope', 'fornecedorService', FornecedoresListagemController]);

    function FornecedoresListagemController($scope, FornecedorService) {
        $scope.ObterFornecedoresAtivos = ObterFornecedoresAtivos;
        ObterFornecedoresAtivos();

        function ObterFornecedoresAtivos() {
            FornecedorService.ObterFornecedoresAtivos().then(function (response) {
                $scope.fornecedores = response;
            });

        }
    }
})();




(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerCadastrarController', ['$scope', 'ShortenerService', '$state', 'SweetAlert', ShortenerCadastrarController]);

    function ShortenerCadastrarController($scope, ShortenerService, $state, SweetAlert) {
        $scope.Cadastrar = Cadastrar;
        $scope.UrlData = {};
        $scope.ObterNovaUrl = ObterNovaUrl;

        function Cadastrar(cadastro) {
            ShortenerService.CadastrarUrl(cadastro).then(function (response) {
                if (response) {
                    SweetAlert.swal("Parabéns", "Salvo com sucesso", "success");
                }
                $state.go('shortener.edit', { UrlId: response })
            })
        }

        function ObterNovaUrl() {
            ShortenerService.ObterNovaUrl().then(function (response) {
                $scope.UrlData.Guid = response.Guid;
                $scope.UrlData.Domain = response.Domain;
            })
        }


    }
})();


(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerController', ['$scope', 'ShortenerService', shortenerController]);

    function shortenerController($scope, ShortenerService) {

        $scope.shorteners = [];
        $scope.totalUrls = 0;

        ObterUrls(1);

        $scope.pesquisar = pesquisar;
        $scope.StatusLink = StatusLink;
        $scope.Confirmacao = Confirmacao;
        $scope.Delete = Delete;
        $scope.pageChaged = pageChaged;

        function pesquisar(search) {
            ShortenerService.Pesquisar(search).then(function (response) {
                $scope.shorteners = response.URLShorteners;
                $scope.totalUrls = response.Count;
            })
        }

        function ObterUrls(page, input) {
            ShortenerService.ObterUrls(page, input).then(function (response) {
                $scope.shorteners = response.URLShorteners;
                $scope.totalUrls = response.Count;
            })
        }

        function pageChaged(newpage, search) {
            ObterUrls(newpage, search);
        }

        function StatusLink(int) {
            if (int)
                return "Ativo"
            return "Inativo"
        }
        function Confirmacao(id, nome) {
            $scope.delete = {};
            $scope.delete.id = id;
            $scope.delete.nome = nome;
            $('#modal').modal("show");
        }
        function Delete(id) {
            $('#modal').modal("hide");
            ShortenerService.Delete(id).then(function (response) {
            })
        }

    }
})();


(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerEditController', ['$scope', '$stateParams', 'ShortenerService','SweetAlert', shortenerEditController]);

    function shortenerEditController($scope, $stateParams, ShortenerService, SweetAlert) {

        $scope.UrlData = {};
        $scope.ObterNovaUrl = ObterNovaUrl;
        $scope.SalvarEdicao = SalvarEdicao;
        $scope.AlteraStatus = AlteraStatus;
        $scope.StartClicks = 0;
        $scope.UrlData.Clicks = 0;

        if ($stateParams.UrlId) {
            ObterDadosUrl($stateParams.UrlId);
        }

        function ObterDadosUrl(id) {
            ShortenerService.ObterDadosUrl(id).then(function (response) {
                $scope.UrlData = response;
                $scope.Texto = $scope.UrlData.Status == 1 ? "Ativo" : "Inativo";
                $scope.checked = $scope.UrlData.Status == 1 ? true : false;
            })
        }

        function ObterNovaUrl() {
            ShortenerService.ObterNovaUrl().then(function (response) {
                $scope.UrlData.Guid = response.Guid;
                $scope.UrlData.Domain = response.Domain;
            })
        }
        function SalvarEdicao(objeto) {
            ShortenerService.SalvarEdicao(objeto).then(function (response) {
                SweetAlert.swal("Parabéns", "Salvo com sucesso", "success");
            })
        }
        function AlteraStatus() {
            if ($scope.UrlData.Status == 1) {
                $scope.UrlData.Status = 0;
                $scope.Texto = "Inativo";
                $('#status').attr('checked', false);
            } else {
                $scope.UrlData.Status = 1;
                $scope.Texto = "Ativo";
                $('#status').attr('checked', true);
            }
        }

    }
})();