import { body, check } from 'express-validator';
import { Application } from 'express';
import { RouteConfig } from "../common/common.route.config";
import  BusinessCompanyRepresentativeController from "./BCR.controller"
import BCRController from './BCR.controller';
import { requiresAuth } from 'express-openid-connect';

export class BcrRoutes extends RouteConfig {
    constructor(app: Application) {
        super(app, "BusinessCompanyRepRoutes")

    }

    configureRoutes() {

        this.app.get(`/business-company-representative/:id`, [
            check('id').isInt().withMessage("The id must be an integer"),],
            [BusinessCompanyRepresentativeController.getSocialActivistTransactionByBCRId])
        
        this.app.post(`/business-company-representative`, [
            body('SA_id').isInt().withMessage("The 'SA_id' parameter must be an integer"),
            body('BCR_id').isInt().withMessage("The 'BCR_id' parameter must be an integer"),
            body('product_id').isInt().withMessage("The 'product_id' parameter must be an integer"),
            body('products_number').isInt().withMessage("The 'products_number' parameter must be an integer"),
            body('price').isInt().withMessage("The 'price' parameter must be an integer")
        ], [BCRController.addSocialActivistTransaction])
        
        this.app.put(`/business-company-representative/:id`, [
            body('SA_id').isInt().withMessage("The 'SA_id' parameter must be an integer"),
            body('BCR_id').isInt().withMessage("The 'BCR_id' parameter must be an integer"),
            body('product_id').isInt().withMessage("The 'product_id' parameter must be an integer"),
            body('products_number').isInt().withMessage("The 'products_number' parameter must be an integer"),
            body('price').isInt().withMessage("The 'price' parameter must be an integer"),
            body('transaction_status_id').isInt().withMessage("The 'transaction_status_id' parameter must be an integer")
        ], [BCRController.updateSocialActivistTransaction])

        this.app.delete(`/business-company-representative/ship/:id`, [
            check('id').isInt().withMessage("The id must be an integer"),],
            [BusinessCompanyRepresentativeController.ShipSocialActivistTransaction])

        this.app.delete(`/business-company-representative/:id`, [
            check('id').isInt().withMessage("The id must be an integer"),],
            [BusinessCompanyRepresentativeController.deleteSocialActivistTransaction])
        
        return this.app
    }
}