module internal Pulsar.Client.Auth.DefaultImplementation

open System
open Pulsar.Client.Auth
open Pulsar.Client.Auth.OAuth2

let newAuthenticationToken (token: string) =
    new AuthenticationToken (token)

let newAuthenticationTls (certFilePath: string) =
    new AuthenticationTls (certFilePath)
    
let newAuthenticationOauth2 (issuerUrl : Uri, audience: string, clientId: string, clientSecret: string, scope: string) =
    new AuthenticationOauth2 (issuerUrl, audience, clientId, clientSecret, scope)