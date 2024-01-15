<<<<<<< HEAD
param location string = 'southeastasia'
=======
param location string = 'westeurope'
>>>>>>> 294ba0192c4d7be6084b7914be1fecee6edd1552
param storageAccountName string
param storageSku string = 'Standard_LRS'

var httpsOnly = true

resource storageAccount 'Microsoft.Storage/storageAccounts@2021-06-01' = {
  name: storageAccountName
  location: location
  sku: {
    name: storageSku
  }
  kind: 'StorageV2'
  properties: {
    supportsHttpsTrafficOnly: httpsOnly
  }
}
